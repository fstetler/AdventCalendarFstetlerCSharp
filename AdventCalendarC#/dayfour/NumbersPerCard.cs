using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayfour {
    public class NumbersPerCard {

        private List<int> numbersYouHave;

        private List<int> winningNumbers;

        private int matchingNumbers;

        private int numberOfTotalCards;


        public NumbersPerCard(List<int> numbersYouHave, List<int> winningNumbers) {
            this.numbersYouHave = numbersYouHave;
            this.winningNumbers = winningNumbers;
        }

        public int totalNumberOfMatchingNumbersPerCard() {
            List<int> matching = new List<int>();
            for (int i = 0; i < winningNumbers.Count; i++) {
                if (numbersYouHave.Contains(winningNumbers[i])) {
                    matching.Add(winningNumbers[i]);
                }
            }
            return matching.Count;
        }

        public int exponentialSumOfNumbersMatchingBetweenOPnHandAndWinningPerGame() {
            return (int ) Math.Pow(2, totalNumberOfMatchingNumbersPerCard() - 1);
        }

        public int getMatchingNumbers() {
            return matchingNumbers;
        }

        public void setMatchingNumbers(int matchingNumbers) {
            this.matchingNumbers = matchingNumbers;
        }


        public int getNumberOfTotalCards() {
            return numberOfTotalCards;
        }
        
        public void addNUmberOfTotalCards(int numberOfTotalCards) {
            this.numberOfTotalCards += numberOfTotalCards;
        }


        public List<int> getWinningNumbers() {
            return winningNumbers;
        }

        public void setWinningNumbers(List<int> winningNumbers) {
            this.winningNumbers = winningNumbers;
        }


        public List<int> getNumbersYouHave() { 
            return numbersYouHave;
        }

        public void setNumbersYouHave(List<int> numbersYouHave) {
            this.numbersYouHave = numbersYouHave;
        }
    }
}
