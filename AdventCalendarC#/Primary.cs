using AdventCalendarC_.dayfour;
using AdventCalendarC_.dayone;
using AdventCalendarC_.daytwo;


namespace AdventCalendarCsharp {
    public class Primary {
        public static void Main(string[] args) {
            DayOne dayOne = new();
            dayOne.PrintSolutionOne();
            dayOne.PrintSolutionTwo();

            DayTwo dayTwo = new();
            dayTwo.PrintSolutionOne();
            dayTwo.PrintSolutionTwo();

            DayFour dayFour = new();
            dayFour.PrintSolutionOne();
            dayFour.PrintSolutionTwo();
        }
    }
}
