namespace AdventCalendarC_.daytwo {
    public class Round(int numberOfGreen, int numberOfRed, int numberOfBlue) {

        private readonly int numberOfGreen = numberOfGreen;
        private readonly int numberOfRed = numberOfRed;
        private readonly int numberOfBlue = numberOfBlue;

        public int NumberOfGreen {
            get => numberOfGreen;
        }

        public int NumberOfRed {
            get => numberOfRed;
        }

        public int NumberOfBlue {
            get => numberOfBlue;
        }
    }
}
