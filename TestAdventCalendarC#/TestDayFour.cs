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
            List<NumbersPerCard> numbersPerCardList = dayFour.allNumbersPerCard(cutStrings);
            NumbersPerCard numberPerCard = numbersPerCardList[0];

            int amountOfWinningNumber = 5;
            int amountOfNUmbersOnHand = 8;

            Assert.That(amountOfWinningNumber, Is.EqualTo(numberPerCard.WinningNumbers.Count));
            Assert.That(amountOfNUmbersOnHand, Is.EqualTo(numberPerCard.NumbersYouHave.Count));
        }

        [Test]
        public void AssertCorrectNumbersOnCard() {
            List<string> strings = new List<string>() {
                "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19"
            };

            DayFour dayFour = new DayFour();
            List<string> cutStrings = dayFour.removeFrontPartOfStrings(strings);
            List<NumbersPerCard> numbersPerCardList = dayFour.allNumbersPerCard(cutStrings);
            NumbersPerCard numbersPerCard = numbersPerCardList[0];

            List<int> winningNumbers = new List<int>() { 13, 32, 20, 16, 61 };
            List<int> numbersYouHave = new List<int>() { 61, 30, 68, 82, 17, 32, 24, 19 };

            Assert.That(winningNumbers, Is.EqualTo(numbersPerCard.WinningNumbers));
            Assert.That(numbersYouHave, Is.EqualTo(numbersPerCard.NumbersYouHave));


        }

    }
}
