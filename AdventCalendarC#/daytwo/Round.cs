using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.daytwo {
    internal class Round {

        private string roundString;
        private int roundNumber;
        private int gameNumber;
        private int numberOfGreen;
        private int numberOfRed;
        private int numberOfBlue;

        public Round(string roundString, int roundNumber, int gameNumber, int numberOfGreen, int numberOfRed, int numberOfBlue) {
            this.roundString = roundString;
            this.roundNumber = roundNumber;
            this.gameNumber = gameNumber;
            this.numberOfGreen = numberOfGreen;
            this.numberOfRed = numberOfRed;
            this.numberOfBlue = numberOfBlue;
        }
    }
}
