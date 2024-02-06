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
            List<string> strings = [line];

            DayFour dayFour = new DayFour();
            List<string> cutStrings = dayFour.RemoveFrontPartOfStrings(strings);
            List<NumbersPerCard> numbersPerCardList = dayFour.AllNumbersPerCard(cutStrings);
            NumbersPerCard numberPerCard = numbersPerCardList[0];

            int amountOfWinningNumber = 5;
            int amountOfNUmbersOnHand = 8;

            Assert.That(amountOfWinningNumber, Is.EqualTo(numberPerCard.getWinningNumbers().Count));
            Assert.That(amountOfNUmbersOnHand, Is.EqualTo(numberPerCard.getNumbersYouHave().Count));
        }

        [Test]
        public void AssertCorrectNumbersOnCard() {
            List<string> strings = ["Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19"];
            
            DayFour dayFour = new DayFour();
            List<string> cutStrings = dayFour.RemoveFrontPartOfStrings(strings);
            List<NumbersPerCard> numbersPerCardList = dayFour.AllNumbersPerCard(cutStrings);
            NumbersPerCard numbersPerCard = numbersPerCardList[0];

            List<int> winningNumbers = new List<int>() { 13, 32, 20, 16, 61 };
            List<int> numbersYouHave = new List<int>() { 61, 30, 68, 82, 17, 32, 24, 19 };

            Assert.That(winningNumbers, Is.EqualTo(numbersPerCard.getWinningNumbers()));
            Assert.That(numbersYouHave, Is.EqualTo(numbersPerCard.getNumbersYouHave()));
        }

        [Test]
        public void verifyAllWinningNumbersFromList() {
            List<string> strings = [
                "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53",
                "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19"];

            DayFour dayFour = new DayFour();

            List<string> cutStrings = dayFour.RemoveFrontPartOfStrings(strings);
            List<NumbersPerCard> numbers = dayFour.AllNumbersPerCard(cutStrings);

            List<int> winningNumbersOne = [41, 48, 83, 86, 17];
            List<int> winningNumberTwo = [13, 32, 20, 16, 61];

            Assert.That(winningNumbersOne, Is.EqualTo(numbers[0].getWinningNumbers()));
            Assert.That(winningNumberTwo, Is.EqualTo(numbers[1].getWinningNumbers()));
        }

        [Test]
        public void totalNumberOfEarnedScratchCards() {
            List<string> strings = [
                "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53",
                "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19",
                "Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1",
                "Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83",
                "Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36",
                "Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"
            ];

            DayFour dayFour = new DayFour();

            List<string> cutStrings = dayFour.RemoveFrontPartOfStrings(strings);
            List<NumbersPerCard> numbers = dayFour.AllNumbersPerCard(cutStrings);
            dayFour.SetMatchingNumberPerCard(numbers);
            Console.WriteLine(numbers[0].getMatchingNumbers());
            dayFour.SetNumberOfTotalPerCard(numbers);
            Console.WriteLine(numbers[0].totalNumberOfMatchingNumbersPerCard);

            int totalSumOfNumbersForTotalPerCard = dayFour.TotalSumFOfNumbersOfTotalPerCard(numbers);

            Assert.That(totalSumOfNumbersForTotalPerCard, Is.EqualTo(30));
        }
    }
}
