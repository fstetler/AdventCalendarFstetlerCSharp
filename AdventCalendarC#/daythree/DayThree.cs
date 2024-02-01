using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_.daythree {
    public class DayThree : PrintSolution {


        public List<Number> numbersOnCurrentLine(string currentLine, int rowIndex) {
            List<Number> numbers = new List<Number>();

            for (int i = 0; i < currentLine.Length; i++) {
                if (Char.IsDigit(currentLine[i])) {
                    Number number = new Number(
                        numberAtIndexOnRow(currentLine, i),
                        rowIndex,
                        i);
                    numbers.Add(number);
                    i = i + number.GetNumberValue().ToString().Length();
                }
            }
            return numbers;

        }


        public void setAdjacentToSymbolForNumbers(List<Number> numbers, List<string> strings) {
            foreach (Number currentNumber in numbers) {
                if (currentNumber.doesNumberHasAdjacentSymbol(strings, currentNumber.getRow(), currentNumber.getColumn(), currentNumber.getNumberValue().ToString().Length())) {
                    currentNumber.setIsAdjacentToSymbol(true);
                };
            }
        }

        public int calculateTotalValueOfAllAdjacentValuesToStar(List<Number> numbers) {
            int totalValue = 0;
            for (int i = 0; i < numbers.Count; i++) { 
                Number number = numbers[i];
                foreach (Number secondNumber in numbers) {
                    totalValue = returnTotalValueIfNumbersAreValid(number, secondNumber, totalValue);
                }
            }
            return totalValue;
        }

        public int returnTotalValueIfNumbersAreValid(Number currentNumber, Number secondNumber, int totalValue) {
            if (currentNumber != secondNumber) {
                if (currentNumber.getAdjacentStarCoordinates() != null & secondNumber.getAdjacentStarCoordinates() != null) {
                    if (currentNumber.getAdjacentStarCoordinates().equals(secondNumber.getAdjacentStarCoordinates())) {
                        if (currentNumber.hasNotBeenUsed() && secondNumber.hasNotBeenUsed()) {
                            totalvalue += currentNumber.getNumberValue() * secondNumber.getnumberValue();
                            currentNumber.setHasBeenUsed(true);
                            secondNumber.setHasBeenUsed(true);
                        }
                    }
                }
            }
            return totalValue;
        }

        public List<Number> listOfAllNumbers(List<string> strings) {
            List<Number> numbersFromAllStrings = new List<Number>();
            for (int i = 0; i < strings.Count; i++) {
                List<Number> numbers = numbersOnCurrentLine(strings[i], i);
                numbersFromAllStrings.AddRange(numbers);
            }
            return numbersFromAllStrings;
        }
        public int numberAtIndexOnRow(Number currentNumber, Number secondNumber, int totalValue) {
            for (int i = 0; i < 4; i++) {
                if (isCharNotDigitOnIndex(numbersOnCurrentLine, columnIndex, i)) {
                    return int.Parse(numbersOnCurrentLine().SubString(columnIndex, columnindex + i));
                }
            }
            return 0;
        }

        public List<string> getListOfStringsFromFile() {
            return Util.getListOfStringsFromFile("resources\\daythree.txt");
        }

        public void PrintSolutionOne() {
            Console.WriteLine(" ");
            Console.WriteLine(this.GetType().Name + " -----------------------");
            Console.WriteLine(resultsPartOne());
        }

        public void PrintSolutionTwo() {
            Console.WriteLine(resultsPartTwo());
        }
    }
}
