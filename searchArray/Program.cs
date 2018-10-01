using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchArray {
    class Program {
        static void Main(string[] args) {
            string[] dwarves = { "DOC", "SLEEPY", "DOPEY", "SNEEZY", "BASHFUL", "GRUMPY", "HAPPY" };
            List<String> gList = new List<String>();

            Console.Write("Enter the name of a dwarf or type 'quit' to end ");
            string value = Console.ReadLine();
            value = value.ToUpper();
            while (value != "QUIT") {
                checkGuess(dwarves, value);
                otherMethod(dwarves, value, ref gList);
                if (gList.Count == 7) {
                    Console.WriteLine("Congratulations! You have guessed all of the dwarves");
                    break;
                } else {
                    Console.Write("Enter the name of a dwarf ");
                    value = Console.ReadLine();
                    value = value.ToUpper();
                }
            }
            Console.WriteLine("Thanks for Playing");
            Console.Read();
        }

        static void checkGuess(string[] myDwarves, string value) {
            int pos = Array.IndexOf(myDwarves, value);
            if (pos > -1) {
                Console.WriteLine("correct");
                
            } else {
                Console.WriteLine("incorrect");
            }
        }

        static void otherMethod(string[] myDwarves, string value, ref List<String> guesses) {
            for (var i = 0; i < myDwarves.Length; i++) {
                if (value == myDwarves[i] && !guesses.Contains(value)) {
                    guesses.Add(value);
                }
            }
        }
    }
}
