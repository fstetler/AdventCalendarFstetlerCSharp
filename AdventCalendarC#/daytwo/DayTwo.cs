namespace AdventCalendarC_.daytwo {
    public class DayTwo : PrintSolution {

        public int results(bool isPartOne) {
            List<string> games = Util.getListOfStringsFromFile("resources\\daytwo.txt");
            if (isPartOne) {
                return sumOfAllValidIDs(games, 13, 14, 12);
            }
            return totalPowerOfAllGames(games);
        }

        public void printSolutionOne() {
            Console.WriteLine("Day One ----------------------------");
            Console.WriteLine("Part one = " + results(true));
        }

        public void printSolutionTwo() {
            Console.WriteLine("Part two = " + results(false));
        }

        public string getCutString(string currentGame) {
            return string.Concat(" ", currentGame.AsSpan(currentGame.IndexOf(": ") + 2));
        }

        public List<Round> getListOfRoundsFromCurrentGame(string currentGame, int gameIndex) {

            string cutString = getCutString(currentGame);
            string[] splitString = cutString.Split(";");
            List<string> stringsForGames = [.. splitString];

            List<Round> rounds = [];

            for (int i = 0; i < stringsForGames.Count; i++) {
                string roundString = stringsForGames[i];
                Round round = new Round(
                    roundString,
                    i,
                    gameIndex,
                    getNumberOfBall(roundString, "green"),
                    getNumberOfBall(roundString, "red"),
                    getNumberOfBall(roundString, "blue"));
                rounds.Add(round);
            }
            return rounds;
        }

        public int sumOfAllValidIDs(List<string> gameStrings, int allowedGreen, int allowedBlue, int allowedRed) {
            List<Game> gameObjects = getListOfAllGames(gameStrings);
            return gameObjects.Where(g => g.canGameBePlayedWithFollowingBalls(allowedGreen, allowedBlue, allowedRed)).Select(g => g.GameIndex+1).Sum();
        }

        public int totalPowerOfAllGames(List<string> gameStrings) {
            List<Game> gameObjects = getListOfAllGames(gameStrings);
            return gameObjects.Select(g => g.MaxNumberOfGreenNeeded * g.MaxNumberOfBlueNeeded * g.MaxNumberOfRedNeeded).Sum();
        }

        public List<Game> getListOfAllGames(List<string> gamesAsStrings) {
            List<Game> gamesAsObjects = new List<Game>();

            for (int i = 0; i < gamesAsStrings.Count(); i++) {
                gamesAsObjects.Add(getGameObjectFromGameString(gamesAsStrings[i], i));
            }
            return gamesAsObjects;
        }

        public Game getGameObjectFromGameString(string currentGameAsString, int index) {
            List<Round> rounds = getListOfRoundsFromCurrentGame(currentGameAsString, index);
            Game game = new Game(index);

            for (int i = 0; i < rounds.Count; i++) {
                game.maxNumberOfBall(rounds[i], "green");
                game.maxNumberOfBall(rounds[i], "blue");
                game.maxNumberOfBall(rounds[i], "red");
            }

            return game;
        }

        public static int getNumberOfBall(string currentRound, string color) {
            for (int i = 0; i < currentRound.Length; i++) {
                if (currentRound.Substring(i).StartsWith(color)) {
                    if (characterAtIndexNotBlank(currentRound, i)) {
                        return 10 * convertCharacterAtIndexToInt(currentRound, i, 3) + convertCharacterAtIndexToInt(currentRound, i, 2);
                    } else {
                        return convertCharacterAtIndexToInt(currentRound, i, 2);
                    }
                }
            }
            return 0;

        }

        public static bool characterAtIndexNotBlank(string currentGame, int index) {
            return !char.IsWhiteSpace(currentGame[index - 3]);
        }

        public static int convertCharacterAtIndexToInt(string currentGame, int index, int offset) {
            return int.Parse(currentGame[index - offset].ToString());
        }
    }
}
