namespace AdventCalendarC_.daytwo {
    public class DayTwo : PrintSolution {

        public void PrintSolutionOne() {
            Console.WriteLine("Day One ----------------------------");
            Console.WriteLine("Part one = " + ResultPartOne());
        }

        public void PrintSolutionTwo() {
            Console.WriteLine("Part two = " + ResultsPartTwo());
        }

        public string GetCutString(string currentGame) {
            return string.Concat(" ", currentGame.AsSpan(currentGame.IndexOf(": ") + 2));
        }

        public List<Round> GetListOfRoundsFromCurrentGame(string currentGame, int gameIndex) {

            string cutString = GetCutString(currentGame);
            string[] splitString = cutString.Split(";");
            List<string> stringRoundsForGames = [.. splitString];

            List<Round> rounds = [];

            return stringRoundsForGames.Select(r => 
                new Round(GetNumberOfBall(r, "green"), GetNumberOfBall(r, "red"), GetNumberOfBall(r, "blue"))).ToList();
        }

        public int SumOfAllValidIDs(List<string> gameStrings, int allowedGreen, int allowedBlue, int allowedRed) {
            List<Game> gameObjects = GetListOfAllGames(gameStrings);
            return gameObjects.Where(g => g.CanGameBePlayedWithFollowingBalls(allowedGreen, allowedBlue, allowedRed)).Select(g => g.GameIndex+1).Sum();
        }

        public int TotalPowerOfAllGames(List<string> gameStrings) {
            List<Game> gameObjects = GetListOfAllGames(gameStrings);
            return gameObjects.Select(g => g.MaxNumberOfGreenNeeded * g.MaxNumberOfBlueNeeded * g.MaxNumberOfRedNeeded).Sum();
        }

        public List<Game> GetListOfAllGames(List<string> gamesAsStrings) {
            List<Game> gamesAsObjects = [];

            for (int i = 0; i < gamesAsStrings.Count(); i++) {
                gamesAsObjects.Add(GetGameObjectFromGameString(gamesAsStrings[i], i));
            }
            return gamesAsObjects;
        }

        public Game GetGameObjectFromGameString(string currentGameAsString, int index) {
            List<Round> rounds = GetListOfRoundsFromCurrentGame(currentGameAsString, index);
            Game game = new(index);

            for (int i = 0; i < rounds.Count; i++) {
                game.MaxNumberOfBall(rounds[i], "green");
                game.MaxNumberOfBall(rounds[i], "blue");
                game.MaxNumberOfBall(rounds[i], "red");
            }

            return game;
        }

        public int GetNumberOfBall(string currentRound, string color) {
            for (int i = 0; i < currentRound.Length; i++) {
                if (currentRound.Substring(i).StartsWith(color)) {
                    if (CharacterAtIndexNotBlank(currentRound, i)) {
                        return 10 * ConvertCharacterAtIndexToInt(currentRound, i, 3) + ConvertCharacterAtIndexToInt(currentRound, i, 2);
                    } else {
                        return ConvertCharacterAtIndexToInt(currentRound, i, 2);
                    }
                }
            }
            return 0;

        }

        private bool CharacterAtIndexNotBlank(string currentGame, int index) {
            return !char.IsWhiteSpace(currentGame[index - 3]);
        }

        private int ConvertCharacterAtIndexToInt(string currentGame, int index, int offset) {
            return int.Parse(currentGame[index - offset].ToString());
        }

        private List<string> InputStrings() {
            return Util.getListOfStringsFromFile("resources\\daytwo.txt");
        }

        private int ResultPartOne() {
            return SumOfAllValidIDs(InputStrings(), 13, 14, 12);
        }

        private int ResultsPartTwo() {
            return TotalPowerOfAllGames(InputStrings());
        }
    }
}
