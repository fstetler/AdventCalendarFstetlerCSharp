namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {

        public void PrintSolutionOne() {
            Console.WriteLine("Day One ----------------------------");
            Console.WriteLine("Part One = " + resultsPartOne(Util.getListOfStringsFromFile("resources\\dayone.txt")));
        }

        public void PrintSolutionTwo() {
            Console.WriteLine("Part Two = " + resultsPartTwo(Util.getListOfStringsFromFile("resources\\dayone.txt")));
        }

        public string returnFirstNumberPartOne(string currentString) {
            return currentString.FirstOrDefault(c => char.IsDigit(c)).ToString();
        }

        public string returnFirstNumberPartTwo(string currentString, List<string> numbersAsWords) {
            for (int i = 0; i < currentString.Length; i++) {
                if (char.IsDigit(currentString[i])) {
                    return currentString[i].ToString();
                }

                for (int j = 0; j < numbersAsWords.Count; j++) {
                    if (currentString.Substring(i).StartsWith(numbersAsWords[j])) {
                        return (j + 1).ToString();
                    }
                }
            }

            throw new NumberNotFoundException("No number in the string was found");
        }

        public int resultsPartOne(List<string> strings) {
            List<string> listOfReversedStrings = reverseStrings(strings);
            List<string> listOfFirstNumbersFromLeft = strings.Select(s => returnFirstNumberPartOne(s)).ToList();
            List<string> listOfFirstNumbersFromRight = listOfReversedStrings.Select(s => returnFirstNumberPartOne(s)).ToList();
            List<string> combinedNumbers = combineLeftAndRightNumberToList(listOfFirstNumbersFromLeft, listOfFirstNumbersFromRight);

            int totalSum = addAllNumbersTogether(combinedNumbers);

            return totalSum;
        }

        public int resultsPartTwo(List<string> strings) {
            List<string> numbersAsWords = getNumbersAsWords();
            List<string> numbersAsWordsReversed = getNumbersAsReversedWords();
            List<string> stringsReversed = reverseStrings(strings);
            List<string> firstNumbersFromLeft = strings.Select(s => returnFirstNumberPartTwo(s, numbersAsWords)).ToList();
            List<string> firstNumbersFromRight = stringsReversed.Select(s => returnFirstNumberPartTwo(s, numbersAsWordsReversed)).ToList();
            List<string> combinedNumbers = combineLeftAndRightNumberToList(firstNumbersFromLeft, firstNumbersFromRight);

            int totalSum = addAllNumbersTogether(combinedNumbers);

            return totalSum;
        }

        public List<string> reverseStrings(List<string> strings) {
            return strings.Select(s => reverseString(s)).ToList();
        }

        private int addAllNumbersTogether(List<string> combinedNumbers) {
            return combinedNumbers.Select(s => int.Parse(s)).Sum();
        }

        private List<string> combineLeftAndRightNumberToList(List<string> left, List<string> right) {
            return left.Zip(right, (left, right) => left + right).ToList();
        }

        private string reverseString(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public List<string> getNumbersAsReversedWords() {
            return getNumbersAsWords().Select(s => reverseString(s)).ToList() ;
        }

        public List<string> getNumbersAsWords() {
            return ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
        }
    }
}
