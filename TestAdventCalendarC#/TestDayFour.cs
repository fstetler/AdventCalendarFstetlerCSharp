using AdventCalendarC_.dayfour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventCalendarC_ {
    public class TestDayFour {

        [Test]
        public void CanReadLine() {
            string line = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
            List<string> strings = new List<string>();
            strings.Add(line);

            DayFour dayFour = new DayFour();
            List<string> cutStrings = dayFour.removeFrontPartOfStrings(strings);
            List<NumbersPerCard> numbersPerCard = dayFour.allNumbersPerCard(cutStrings);


        }

    }
}
