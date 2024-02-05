using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayfour {
    public class NumbersPerCard {

        private int NumberOfToTalCardsFIeld;

        public NumbersPerCard(List<int> numbersYouHave, List<int> winningNumbers) {
            this.NumbersYouHave = numbersYouHave;
            this.WinningNumbers = winningNumbers;
        }

        public int totalNumberOfMatchingNumbersPerCard() {
            int count = 0;
            
            for (int i = 0; i < WinningNumbers.Count; i++) {
                if (NumbersYouHave.Contains(WinningNumbers[i])) {
                    count += 1;
                }
            }
            return count;
        }

        public int exponentialSumOfNumbersMatchingBetweenOPnHandAndWinningPerGame() {
            return (int ) Math.Pow(2, totalNumberOfMatchingNumbersPercard() - 1);
        }

        public int totalNumberOfMatchingNumbersPercard() {
            return WinningNumbers.Select(wn => NumbersYouHave.Contains(wn)).ToList().Count;
        }

        public void addNUmberOfTotalCards(int numberOfTotalCards) {
            this.NumberOfToTalCardsFIeld += numberOfTotalCards;
        }

        public List<int> NumbersYouHave { get; set; }
        public List<int> WinningNumbers { get; set; }
        public int MatchingNumbers { get; set; }
        public int getNumberOfToTalCardsFIeld { get => this.NumberOfToTalCardsFIeld; }
    }
}
