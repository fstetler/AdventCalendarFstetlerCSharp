
using AdventCalendarC_.daytwo;

namespace TestAdventCalendarC_ {
    public class TestDayTwo {

        [Test]
        public void testSumOfIDsFromAcceptableGames() {
            List<string> games = new List<string>() {
                "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green;",
                "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue;",
                "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red;",
                "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red;",
                "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green;"
            };

            DayTwo dayTwo = new DayTwo();
            int totalSum = dayTwo.sumOfAllValidIDs(games, 13, 14, 12);
            Assert.That(totalSum, Is.EqualTo(8));
        }

        [Test]
        public void testSumOfAllPoweredValues() {
            List<string> games = new List<string>() {
                "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green;",
                "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue;",
                "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red;",
                "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red;",
                "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green;"
            };

            DayTwo dayTwo = new DayTwo();

            Assert.That(dayTwo.totalPowerOfAllGames(games), Is.EqualTo(2286));
        }
    }
}
