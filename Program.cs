// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Runtime.InteropServices;

namespace VirtualPet {
    
    class Program {

        static FileManagement fManager = new FileManagement();
        
        static void Main(string[] args) {
            string option = "0";
            string name = "";
            Pet myPet;
            

            Console.WriteLine("Welcome to Console Companion!");
            Console.WriteLine("");
            do {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine();
                Console.WriteLine("1) New Companion.");
                Console.WriteLine("2) Existing Compation.");
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
                        Game(myPet);
                        break;
                    case "2":
                        string[] pInfo = fManager.Load();

                        if (pInfo.Length == 0) {
                            Console.WriteLine("Error loading file, please try again.");
                        } else {
                            myPet = new Pet(pInfo);
                            Game(myPet);
                        }
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

        static void Game(Pet pet) {
            string option = "0";
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine($"{pet.Name} is here to keep you company.");

            do {
                Console.WriteLine($"{pet.Name} is currently {pet.State}, they are {pet.Age} cycles old.");
                Console.WriteLine($"{pet.Name}s stats are as follows:");
                Console.WriteLine("");
                Console.WriteLine($"Weight: {pet.Weight}");
                Console.WriteLine($"Hunger: {pet.Hunger}");
                Console.WriteLine($"Health: {pet.Health}");
                Console.WriteLine($"Happiness: {pet.Happiness}");
                Console.WriteLine($"Energy: {pet.Energy}");
                Console.WriteLine("");
                Console.WriteLine($"What would you like to do with {pet.Name}?");
                Console.WriteLine("1)Pet them (Not Implemented)");
                Console.WriteLine("3)Feed them");
                Console.WriteLine("5)Play with them");
                Console.WriteLine("7)Walk them");
                Console.WriteLine("9)Visit somewhere (Not Implemented)");
                Console.WriteLine("0)Let them rest for a while.");
                
                option = Console.ReadLine();

                switch (option) {
                    case "3":
                        pet.Feed();
                        break;
                    case "5":
                        pet.Play();
                        break;
                    case "7":
                        pet.Walk();
                        break;
                    case "0":
                        Console.WriteLine($"Saving {pet.Name}.");
                        fManager.Save(pet);
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }                       
            } while (option != "0"); 
            Console.Beep();
            Console.Clear();           
        }
    }
}
