using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode {
    internal class Day01 {
        public static int Part1() {
            int finalValue = 0;
            StreamReader sr = new StreamReader(new FileStream("input_day01_part1.txt", FileMode.OpenOrCreate));
            string temp;
            while ((temp = sr.ReadLine()) != null) {
                char[] tempArray = temp.ToCharArray();
                char firstDigit = '\0';
                char secondDigit = '\0';
                for (int i = 0; i < tempArray.Length; i++) {
                    if (Char.IsDigit(tempArray[i])) {
                        if (firstDigit == '\0') {
                            firstDigit = tempArray[i];
                        }
                        secondDigit = tempArray[i];
                    }
                }
                temp = Convert.ToString(firstDigit) + Convert.ToString(secondDigit);
                finalValue += Convert.ToInt32(temp);
            }
            sr.Close();
            return finalValue;
        }

        public static int Part2() {
            int finalValue = 0;
            StreamReader sr = new StreamReader(new FileStream("input_day01_part2.txt", FileMode.OpenOrCreate));
            string temp;
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] newDigits = { "z0ro", "o1e", "t2o", "th3ee", "f4ur", "f5ve", "s6x", "se7en", "ei8ht", 
"n9ne" };

            while ((temp = sr.ReadLine()) != null) {
                for (int i = 0; i < digits.Length; i++) {
                    temp = temp.Replace(digits[i], newDigits[i]);
                }
                Console.WriteLine(temp);

                char[] tempArray = temp.ToCharArray();
                char firstDigit = '\0';
                char secondDigit = '\0';
                for (int i = 0; i < tempArray.Length; i++) {
                    if (Char.IsDigit(tempArray[i])) {
                        if (firstDigit == '\0') {
                            firstDigit = tempArray[i];
                        }
                        secondDigit = tempArray[i];
                    }
                }
                temp = Convert.ToString(firstDigit) + Convert.ToString(secondDigit);
                finalValue += Convert.ToInt32(temp);
            }
            sr.Close();
            return finalValue;
        }
    }
}
