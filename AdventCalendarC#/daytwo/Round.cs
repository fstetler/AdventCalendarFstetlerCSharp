namespace AdventCalendarC_.daytwo {
    public class Round {

        private string roundString;
        private int roundNumber;
        private int gameNumber;
        private int numberOfGreen;
        private int numberOfRed;
        private int numberOfBlue;

        public Round(string roundString, int roundNumber, int gameNumber, int numberOfGreen, int numberOfRed, int numberOfBlue) {
            this.RoundString = roundString;
            this.RoundNumber = roundNumber;
            this.GameNumber = gameNumber;
            this.NumberOfGreen = numberOfGreen;
            this.NumberOfRed = numberOfRed;
            this.NumberOfBlue = numberOfBlue;
        }

        public string RoundString { 
            get => roundString; 
            set => roundString = value; 
        }

        public int RoundNumber {
            get => roundNumber; 
            set => roundNumber = value; 
        }

        public int GameNumber { 
            get => gameNumber; 
            set => gameNumber = value;
        }

        public int NumberOfGreen { 
            get => numberOfGreen; 
            set => numberOfGreen = value;
        }

        public int NumberOfRed { 
            get => numberOfRed; 
            set => numberOfRed = value;
        }

        public int NumberOfBlue { 
            get => numberOfBlue; 
            set => numberOfBlue = value; 
        }
    }
}
