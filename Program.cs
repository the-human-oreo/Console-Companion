using System.Collections;
using System.Runtime.InteropServices;

namespace VirtualPet {
    
    public class Program {    
        static void Main(string[] args) {
            string option = "0";
            string name = "";
            Pet myPet;
            GameManager gameManager = new GameManager();

            Console.WriteLine("Welcome to Console Companion!");
            Console.WriteLine("");
            do {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine();
                Console.WriteLine("1) New Companion.");
                Console.WriteLine("2) Existing Companion.");
                Console.WriteLine("9) Information.");
                Console.WriteLine("0) Quit.");
                option = Console.ReadLine();

                switch (option) {
                    case "1":
                        do {
                            Console.WriteLine("");
                            Console.WriteLine("Please enter a name for your pet:"); 
                            name = Console.ReadLine();
                        } while (name == "");
                        myPet = new Pet(name); 
                        gameManager.StartGame(myPet);
                        break;
                    case "2":
                        Console.WriteLine("Not Implemented");
                        break;
                    case "9":
                        Console.WriteLine("Not Implemented");
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }

            } while(option != "0");
        }
    }
}
