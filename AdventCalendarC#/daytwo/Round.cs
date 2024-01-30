namespace AdventCalendarC_.daytwo {
    public class Round {

        private int numberOfGreen;
        private int numberOfRed;
        private int numberOfBlue;

        public Round(int numberOfGreen, int numberOfRed, int numberOfBlue) {
            this.NumberOfGreen = numberOfGreen;
            this.NumberOfRed = numberOfRed;
            this.NumberOfBlue = numberOfBlue;
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
