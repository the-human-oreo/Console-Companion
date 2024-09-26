namespace  VirtualPet {
    public class GameManager {
        // FeedInterface feed = FeedFactory.Create("");
        FileManagement fManager = new FileManagement(); // Ensure fManager is accessible
        public void StartGame(Pet pet) {
            string option = "0";
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine($"{pet.name} is here to keep you company.");

            do {
                pet.Stats();
                Console.WriteLine("");
                Console.WriteLine($"What would you like to do with {pet.name}?");
                Console.WriteLine("1) Pet them (Not Implemented)");
                Console.WriteLine("3) Feed them");
                Console.WriteLine("5) Play with them");
                Console.WriteLine("7) Walk them");
                Console.WriteLine("8) Let them nap");
                Console.WriteLine("9) Visit somewhere (Not Implemented)");
                Console.WriteLine("0) Let them rest for a while.");
                
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
                    case "8":
                        pet.Nap();
                        break; 
                    case "0":
                        Console.WriteLine($"Saving {pet.name}.");
                        fManager.Save(pet);
                        break;
                    default:
                        Console.WriteLine("Incorrect Input");
                        break;
                }                       
            } while (option != "0"); 
            Console.Clear();           
        }
    }
}