using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode {
    class Day02 {
        public static int Part1(int red, int green, int blue) {
            int sumIDs = 0;
            string temp;
            StreamReader sr = new StreamReader(new FileStream("input_day02_part1.txt", FileMode.OpenOrCreate));
            while ((temp = sr.ReadLine()) != null) {
                bool legal = true;
                int id = Convert.ToInt32(temp.Split(':')[0].Split(' ')[1]);
                string[] sets = temp.Split(':')[1].Split(';');
                foreach (var set in sets) {
                    if (!legal) {
                        break;
                    } 
                    string[] cubes = set.Split(',');
                    foreach (var cube in cubes) {
                        if (!legal) {
                            break;
                        }
                        switch (cube.Split(' ')[2]) {
                            case "red": 
                                if (Convert.ToInt32(cube.Split(' ')[1]) > red) {
                                    legal = false;
                                }
                                break;
                            case "green":
                                if (Convert.ToInt32(cube.Split(' ')[1]) > green) {
                                    legal = false;
                                }
                                break;
                            case "blue":
                                if (Convert.ToInt32(cube.Split(' ')[1]) > blue) {
                                    legal = false;
                                }
                                break;
                            default: break;
                        }
                    }
                }
                if (legal) {
                    sumIDs += id;
                }
            }
            sr.Close();
            return sumIDs;
        }

        public static int Part2() {
            int sumIDs = 0;
            string temp;
            StreamReader sr = new StreamReader(new FileStream("input_day02_part2.txt", FileMode.OpenOrCreate));
            while ((temp = sr.ReadLine()) != null) {
                int red = 0;
                int green = 0;
                int blue = 0;
                string[] sets = temp.Split(':')[1].Split(';');
                foreach (var set in sets) {
                    string[] cubes = set.Split(',');
                    foreach (var cube in cubes) {
                        switch (cube.Split(' ')[2]) {
                            case "red":
                                if (Convert.ToInt32(cube.Split(' ')[1]) > red) {
                                    red = Convert.ToInt32(cube.Split(' ')[1]);
                                }
                                break;
                            case "green":
                                if (Convert.ToInt32(cube.Split(' ')[1]) > green) {
                                    green = Convert.ToInt32(cube.Split(' ')[1]);
                                }
                                break;
                            case "blue":
                                if (Convert.ToInt32(cube.Split(' ')[1]) > blue) {
                                    blue = Convert.ToInt32(cube.Split(' ')[1]);
                                }
                                break;
                            default: break;
                        }
                    }
                }
                sumIDs += red * green * blue;
            }
            sr.Close();
            return sumIDs;
        }
    }
}
