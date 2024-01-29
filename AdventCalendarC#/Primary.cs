
using AdventCalendarC_;
using AdventCalendarC_.dayone;
using AdventCalendarC_.daytwo;


namespace AdventCalendarCsharp {
    public class Primary {
        public static void Main(string[] args) {
            DayOne dayOne = new DayOne();
            dayOne.printSolutionOne();
            dayOne.printSolutionTwo();

            DayTwo dayTwo = new DayTwo();
            dayTwo.printSolutionOne();
            dayTwo.printSolutionTwo();
        }
    }
}
