using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayfour {
    public class DayFour : PrintSolution {

        //public List<NumbersPerCard> createNumbersPerCardList(List<string> cutStrings) {
        //    return cutStrings.Select(cs => ) 
        //}

        public NumbersPerCard createNumbersPerCard(string cutString) {
            List<int> winning = winningNumbers(cutString);
            List<int> numbers = numbersYouHave(cutString);
            return new NumbersPerCard(numbers, winning);
        }

        private List<int> winningNumbers(string cutString) {
            return listOfNumbers(cutString.Split("|")[0]);
        }

        private List<int> numbersYouHave(string cutString) {
            return listOfNumbers(cutString.Split("|")[1]);
        }


        private List<int> listOfNumbers(string numbersString) {
            string[] numbersStrings = numbersString.Trim().Split("\\s+");
            List<int> integerList = new List<int>();
            foreach (string number in numbersStrings) {
                integerList.Add(int.Parse(number));
            }
            return integerList;
        }

        public List<string> removeFrontPartOfStrings(List<string> strings) {
            return strings.Select(s => s.Split(":").Last()).ToList();
        }

        public void PrintSolutionOne() {
            throw new NotImplementedException();
        }

        public void PrintSolutionTwo() {
            throw new NotImplementedException();
        }

        public List<string> getStringsFromFile() {
            return Util.getListOfStringsFromFile("resources\\dayfour.txt");
        }

    }
}
