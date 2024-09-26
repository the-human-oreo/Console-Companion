namespace  VirtualPet {
    public class GameManager {
        FileManagement fManager = new FileManagement(); // Ensure fManager is accessible
        LocationInterface lInterface;
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
                Console.WriteLine("1) Pet them");
                Console.WriteLine("3) Feed them");
                Console.WriteLine("5) Play with them");
                Console.WriteLine("7) Walk them");
                Console.WriteLine("8) Let them nap");
                Console.WriteLine("9) Visit somewhere");
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
                    case "9":
                        Console.WriteLine($"Where would you like to visit with {pet.name}?");
                        string suboption = "0";
                        do {
                            Console.WriteLine("1) The Park");
                            Console.WriteLine("2) The City");
                            Console.WriteLine("3) The Vet");
                            Console.WriteLine("0) Return home.");
                            suboption = Console.ReadLine();

                            switch (suboption) {
                            case "1":
                                lInterface = LocationFactory.Create(LocationMethod.ParkLocation);
                                pet.Loop();
                                lInterface.Visit(pet);
                                break;
                            case "2":
                                lInterface = LocationFactory.Create(LocationMethod.CityLocation);
                                lInterface.Visit(pet);
                                pet.Loop();
                                break;
                            case "3":
                                lInterface = LocationFactory.Create(LocationMethod.VetLocation);
                                lInterface.Visit(pet);
                                pet.Loop();
                                break;
                            case "0":
                                break;
                            default:
                                Console.WriteLine("Incorrect Input");
                                break;
                            }
            } while (option !="0"); 
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