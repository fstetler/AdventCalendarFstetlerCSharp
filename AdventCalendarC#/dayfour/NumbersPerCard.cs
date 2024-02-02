using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayfour {
    public class NumbersPerCard {

        private List<int> numbersYouHave;

        private List<int> winningNumbers;

        private int matchingNumbers;

        private int numbersOfTotalCards;

        public NumbersPerCard(List<int> numbersYouHave, List<int> winningNumbers) {
            this.NumbersYouHave = numbersYouHave;
            this.WinningNumbers = winningNumbers;
        }

        public List<int> NumbersYouHave { get => numbersYouHave; set => numbersYouHave = value; }
        public List<int> WinningNumbers { get => winningNumbers; set => winningNumbers = value; }
        public int MatchingNumbers { get => matchingNumbers; set => matchingNumbers = value; }
        public int NumbersOfTotalCards { get => numbersOfTotalCards; set => numbersOfTotalCards = value; }
    }
}
