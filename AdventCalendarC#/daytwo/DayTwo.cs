namespace AdventCalendarC_.daytwo {
    public class DayTwo : PrintSolution {

        public void PrintSolutionOne() {
            Console.WriteLine("Day One ----------------------------");
            Console.WriteLine("Part one = " + ResultPartOne());
        }

        public void PrintSolutionTwo() {
            Console.WriteLine("Part two = " + ResultsPartTwo());
        }

        public int SumOfAllValidIDs(List<Game> gameObjects, int allowedGreen, int allowedBlue, int allowedRed) {
            return gameObjects.Where(g => g.CanGameBePlayedWithFollowingBalls(allowedGreen, allowedBlue, allowedRed)).Select(g => g.GameIndex+1).Sum();
        }

        public int TotalPowerOfAllGames(List<Game> gameObjects) {
            return gameObjects.Select(g => g.MaxNumberOfGreenNeeded * g.MaxNumberOfBlueNeeded * g.MaxNumberOfRedNeeded).Sum();
        }

        public List<Game> GetListOfAllGames(List<string> gamesAsStrings) {
            return gamesAsStrings.Select(gs => GetGameObjectFromGameString(gs, gamesAsStrings.IndexOf(gs))).ToList();
        }

        private List<string> GetRoundsAsStringsForGames(string cutString) {
            string[] splitString = cutString.Split(";");
            List<string> stringRoundsForGames = [.. splitString];
            return stringRoundsForGames;
        }

        private List<Round> GetListOfRoundsFromCurrentGame(string currentGame) {

            string cutString = GetCutString(currentGame);
            List<string> stringRoundsForGames = GetRoundsAsStringsForGames(cutString);

            return stringRoundsForGames.Select(r =>
                new Round(
                    GetNumberOfBall(r, "green"),
                    GetNumberOfBall(r, "red"),
                    GetNumberOfBall(r, "blue")))
                .ToList();
        }

        private Game GetGameObjectFromGameString(string currentGameAsString, int index) {
            List<Round> rounds = GetListOfRoundsFromCurrentGame(currentGameAsString);
            Game game = new(index);

            rounds.ForEach(r => {
                game.MaxNumberOfBall(r, "green");
                game.MaxNumberOfBall(r, "blue");
                game.MaxNumberOfBall(r, "red");
            });

            return game;
        }

        private int GetNumberOfBall(string currentRound, string color) {
            for (int i = 0; i < currentRound.Length; i++) {
                if (currentRound.Substring(i).StartsWith(color)) {
                    return TotalNumberOfBallsForOneColor(currentRound, i);         
                }
            }
            return 0;
        }

        private int TotalNumberOfBallsForOneColor(string currentRound, int index) {
            if (BallColorHasValueOver10(currentRound, index)) {
                return 10 * ConvertCharacterAtIndexToInt(currentRound, index, 3) + ConvertCharacterAtIndexToInt(currentRound, index, 2);
            } else {
                return ConvertCharacterAtIndexToInt(currentRound, index, 2);
            }
        }

        private bool BallColorHasValueOver10(string currentGame, int index) {
            return !char.IsWhiteSpace(currentGame[index - 3]);
        }

        private int ConvertCharacterAtIndexToInt(string currentGame, int index, int offset) {
            return int.Parse(currentGame[index - offset].ToString());
        }

        private List<string> InputStrings() {
            return Util.getListOfStringsFromFile("resources\\daytwo.txt");
        }

        private int ResultPartOne() {
            List<string> inputStrings = InputStrings();
            List<Game> gameObjects = GetListOfAllGames(inputStrings);
            return SumOfAllValidIDs(gameObjects, 13, 14, 12);
        }

        private int ResultsPartTwo() {
            List<string> inputStrings = InputStrings();
            List<Game> gameObjects = GetListOfAllGames(inputStrings);
            return TotalPowerOfAllGames(gameObjects);
        }

        private string GetCutString(string currentGame) {
            return string.Concat(" ", currentGame.AsSpan(currentGame.IndexOf(": ") + 2));
        }
    }
}
