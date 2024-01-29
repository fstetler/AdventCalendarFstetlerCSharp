using AdventCalendarC_.dayone;
using System.Collections;

namespace TestAdventCalendarC_ {
    public class Tests {


        [Test]
        public void testTotalSumOfEntireListPartOne() { 
        
            List<string> listOfStrings = new List<string>() {
                "1abc2",
                "pqr3stu8vwx",
                "a1b2c3d4e5f",
                "treb7uchet"
            };

            DayOne dayOne = new DayOne();
            int totalSum = dayOne.resultsPartOne(listOfStrings);

            Assert.That(totalSum, Is.EqualTo(142));
        }


        [Test]
        public void testFirstNumberFromRightOnEachRowPartOne() {
            List<string> listOfStrings = new List<string>() {
                "two1nine",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "sevenine3",
                "seightwoone8qxcfgszninesvfcnxc68"
            };


            List<string> answers = new List<string>() {
                "1", "2", "3", "2", "4", "3", "8"
            };

            DayOne dayOne = new DayOne();
            List<string> listOfReversedStrings = dayOne.reverseStrings(listOfStrings);
            List<string> firstNumberFromLeftList = listOfReversedStrings.Select(s => dayOne.returnFirstNumberPartOne(s)).ToList();

            Assert.That(firstNumberFromLeftList, Is.EqualTo(answers));
        }

        [Test]
        public void testFirstNumberFromLeftOnEachRowPartOne() {
            List<string> listOfStrings = new List<string>() {
                "two1nine",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "sevenine3",
                "seightwoone8qxcfgszninesvfcnxc68"
            };

            List<string> answers = new List<string>() {
                "1", "2", "3", "4", "2", "3", "8"
            };

            DayOne dayOne = new DayOne();
            List<string> firstNumberFromLeftList = listOfStrings.Select(s => dayOne.returnFirstNumberPartOne(s)).ToList();

            Assert.That(firstNumberFromLeftList, Is.EqualTo(answers));


        }

        [Test]
        public void testTotalSumOfEntireListPartTwo() {
            List<string> listOfStrings = new List<string>() {
                "two1nine",
                "eightwothree",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "7pqrstsixteen"
            };

            DayOne dayOne = new DayOne();

            int totalSum = dayOne.resultsPartTwo(listOfStrings);

            Assert.That(totalSum, Is.EqualTo(281));
        }


        [Test]
        public void testFirstNumberFromLeftOnEachRowForPartTwo() {
            List<string> listOfStrings = new List<string>() {
                "two1nine",
                "eightwothree",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "sevenine3",
                "threeighthree",
                "nineighthree",
                "seightwoone8qxcfgszninesvfcnxc68"
            };

            List<string> answers = new List<string>() {
                "2", "8", "1", "2", "4", "1", "7", "3", "9", "8"
            };

            DayOne dayOne = new DayOne();
            List<string> listOfNumbersAsWords = dayOne.getNumbersAsWords();
            List<string> firstNumberFromLeftList = listOfStrings.Select(s => dayOne.returnFirstNumberPartTwo(s, listOfNumbersAsWords)).ToList();

            Assert.That(firstNumberFromLeftList, Is.EqualTo(answers));
        }

        [Test]
        public void testFirstNumberFromRightOnEachRowForPartTwo() {
            List<string> listOfStrings = new List<string>() {
                "two1nine",
                "eightwothree",
                "abcone2threexyz",
                "xtwone3four",
                "4nineeightseven2",
                "zoneight234",
                "sevenine3",
                "threeighthree",
                "nineighthree",
                "seightwoone8qxcfgszninesvfcnxc68"
            };

            List<string> answers = new List<string>() {
                "9", "3", "3", "4", "2", "4", "3", "3", "3", "8"
            };

            DayOne dayOne = new DayOne();
            List<string> listOfNumbersAsReversedWords = dayOne.getNumbersAsReversedWords();
            List<string> listOfReversedStrings = dayOne.reverseStrings(listOfStrings);
            List<string> firstNumberFromRightList = listOfReversedStrings.Select(s => dayOne.returnFirstNumberPartTwo(s, listOfNumbersAsReversedWords)).ToList();

            Assert.That(firstNumberFromRightList, Is.EqualTo(answers));
        }
    }
}