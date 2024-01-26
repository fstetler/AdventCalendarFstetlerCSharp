using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.dayone {
    public class DayOne : PrintSolution {


        public string returnFirstNumberFromString(string currentString, bool reversed, bool partOne) {

            List<string> listOfNumbersAsWords;
            if (reversed) {
                listOfNumbersAsWords = new List<string>() { "eno", "owt", "eerht", "ruof", "evif", "xis", "neves", "thgie", "enin" };
                currentString = reverseString(currentString);
            } else {
                listOfNumbersAsWords = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            }

            for (int i = 0; i < currentString.Length; i++) {
                if (char.IsDigit(currentString[i])) {
                    return currentString[i].ToString();
                }
                if (!partOne) {
                    for (int j = 0; j < listOfNumbersAsWords.Count; j++) {
                        if (currentString.Substring(i).StartsWith(listOfNumbersAsWords[j])) {
                            return (j+1).ToString();
                        }
                    }
                }
            }

            return null;
        }

        public int addAllNumbersTogether(List<string> listOfCombinedNumbers) {
            int sum = 0;

            foreach (string s in listOfCombinedNumbers) {
                sum += int.Parse(s);
            }
            return sum;
        }


        public string reverseString(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        



        public void printSolutionOne() {
        

        }

        public void printSolutionTwo() {
        }
    }
}
