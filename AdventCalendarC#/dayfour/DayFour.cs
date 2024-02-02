using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayfour {
    public class DayFour : PrintSolution {

        public List<NumbersPerCard> createNumbersPerCardList(List<string> cutStrings) {
            return cutStrings.Select(cs => )
        }

        public NumbersPerCard createNumbersPerCard(string cutString) {
            string winningNumbers = cutString.Split("|").First();
            string numbersYouHave = cutString.Split("|").Last();
            List<int> winning = listOfNumbers(winningNumbers);
            List<int> numbers = listOfNumbers(numbersYouHave);
            return new NumbersPerCard(numbers, winning);
        }


        private List<int> listOfNumbers(string numbersString) {
            string[] numbersStrings = numbersString.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
