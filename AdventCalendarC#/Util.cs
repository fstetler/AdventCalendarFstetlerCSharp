using AdventCalendarC_.dayone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarC_ {
    public class Util {

        public static List<String> getListOfStringsFromFile(String fileName) {

            List<string> strings = new List<string>();

            try {
                strings = File.ReadAllLines(fileName).ToList();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return strings;
        }
    }
}
