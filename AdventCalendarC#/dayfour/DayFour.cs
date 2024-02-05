using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayfour {
    public class DayFour : PrintSolution {

        public List<NumbersPerCard> AllNumbersPerCard(List<string> cutStrings) {
            return cutStrings.Select(cs => CreateNumbersPerCard(cs)).ToList();
        }

        public int totalSumOfAllExponentialValues(List<NumbersPerCard> listOfNumbersPerCard) {
            return listOfNumbersPerCard.Select(npc => npc.exponentialSumOfNumbersMatchingBetweenOPnHandAndWinningPerGame()).Sum();
        }

        public NumbersPerCard CreateNumbersPerCard(string cutString) {
            string winningNumbers = cutString.Split("|")[0];
            string numbersYouHave = cutString.Split("|")[1];
            List<int> winning = ListOfNumbers(winningNumbers);
            List<int> numbers = ListOfNumbers(numbersYouHave);
            return new NumbersPerCard(numbers, winning);
        }

        public void SetMatchingNumberPerCard(List<NumbersPerCard> numbersPerCardList) {
            for (int i = 0; i < numbersPerCardList.Count; i++) {
                numbersPerCardList[i].MatchingNumbers = numbersPerCardList[i].totalNumberOfMatchingNumbersPerCard();
            }
        }

        public void SetNumberOfTotalPerCard(List<NumbersPerCard> numbersPerCarList) {
            foreach (NumbersPerCard numbersPerCard in numbersPerCarList) {
                numbersPerCard.addNUmberOfTotalCards(1);
            }
            for (int i = 0; i < numbersPerCarList.Count; i++) {
                for (int j = i + 1; j <= i + numbersPerCarList[i].MatchingNumbers; j++) {
                    int numberOfTotalCards = numbersPerCarList[i].getNumberOfToTalCardsFIeld;
                    numbersPerCarList[j].addNUmberOfTotalCards(numberOfTotalCards);
                }
            }
        }

        public int TotalSumFOfNumbersOfTotalPerCard(List<NumbersPerCard> numbersPerCardList) {
            return numbersPerCardList.Select(n => n.getNumberOfToTalCardsFIeld).Sum();    
        }

        private List<int> ListOfNumbers(string numbersString) {
            string[] numbersStrings = numbersString.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> integerList = new List<int>();
            foreach (string number in numbersStrings) {
                integerList.Add(int.Parse(number));
            }
            return integerList;
        }

        public List<string> RemoveFrontPartOfStrings(List<string> strings) {
            return strings.Select(s => s.Split(":").Last()).ToList();
        }

        public int results(Boolean isPartOne) {
            List<string> strings = GetStringsFromFile();
            List<string> cutStrings = RemoveFrontPartOfStrings(strings);
            List<NumbersPerCard> allNumbersPercard = AllNumbersPerCard(cutStrings);
            SetMatchingNumberPerCard(allNumbersPercard);
            SetNumberOfTotalPerCard(allNumbersPercard);

            if (isPartOne) {
                return totalSumOfAllExponentialValues(allNumbersPercard);
            }
            return TotalSumFOfNumbersOfTotalPerCard(allNumbersPercard);
        }

        public void PrintSolutionOne() {
            Console.WriteLine(results(true));
        }

        public void PrintSolutionTwo() {
            Console.WriteLine(results(false));
        }

        public List<string> GetStringsFromFile() {
            return Util.getListOfStringsFromFile("resources\\dayfour.txt");
        }

    }
}
