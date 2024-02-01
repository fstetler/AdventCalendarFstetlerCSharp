using AdventCalendarC_.daythree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventCalendarC_ {
    public class TestDayThree {

        [Test]
        public void testSumOfGears() {
            List<string> strings = new List<string>() {
                ".............",
                ".467..114....",
                "...*.........",
                "..35..633....",
                "......#......",
                ".617*........",
                "......+.58...",
                "...592.......",
                ".......755...",
                "....$.*......",
                "..664.598....",
                "............."
            };

            DayThree dayThree = new DayThree();
            List<Number> numbers = dayThree.listOfAllNumbers(strings);
            dayThree.setAdjacentToSymbolForNumbers(numbers, strings);
            Assert.That(dayThree.calculateTotalValueOfAllAdjacentValuesToStar(numbers), Is.EqualTo(467835));
        }

        [Test]
        public void testSumOfGearspartTwo() {
            List<string> strings = new List<string>() {
                ".............",
                ".467..114....",
                "...*.........",
                "..35..633....",
                "......#......",
                ".617*........",
                "......+.58...",
                "...592.......",
                ".......755...",
                "....$.*......",
                "..664.598....",
                "............."
            };

            DayThree dayThree = new DayThree();
            List<Number> numbers = dayThree.listOfAllNumbers(strings);
            dayThree.setAdjacentToSymbolForNumbers(numbers, strings);
            Assert.That(dayThree.getTotalAddedNumbersAdjacentToSymbol(numbers), Is.EqualTo(4361));
 

        }


    }
}
