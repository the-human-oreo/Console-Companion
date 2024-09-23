using System;

namespace VirtualPet {
    public class FileManagement() {

        static string pathWay = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string fName;
        public void Save(Pet sPet) {
            fName = null;
            do {
                Console.WriteLine("Please name your save:");
                fName = Console.ReadLine();         
            } while (fName == null);

            fName += ".pet";
            
            string[] sData = {
                "Name:" + sPet.name,
                "Age:" + sPet.age,
                "Weight:" + sPet.weight,
                "Hunger:" + sPet.hunger,
                "Health:" + sPet.health,
                "Energy:" + sPet.energy,
                "Happiness:" + sPet.happiness,
                "State:" + sPet.state
            };

            File.AppendAllLines(Path.Combine(pathWay, fName), sData);
        }

        public string[] Load() {
            fName = null;
            string[] files = Directory.GetFiles(pathWay, "*.pet");
            Console.WriteLine($"{files.Length} save file(s) located:");

            for (int i = 0; i < files.Length ; i++) {
                files[i] = files[i].Split(@"\")[files[i].Split(@"\").Length - 1];
                files[i] = files[i].Split(".")[0];
                Console.WriteLine(files[i]);                
            }
               
            Console.WriteLine("If you wish to load one of these files then type in the name when prompted.");
            Console.WriteLine("If your save file isn't showing up please make sure it is located in \"My Documents\"");
            

            do {
                Console.WriteLine("Please enter the name of the file you wish to load: ");
                fName = Console.ReadLine();         
            } while (fName == null);

            fName += ".pet";

            string[] lData = File.ReadAllLines(Path.Combine(pathWay, fName));

            int colonPos = 0;

            

            for (int i = 0; i < lData.Length ; i++) {
                Console.Write(lData[i]);
                colonPos = lData[i].IndexOf(':');
                lData[i] = lData[i].Substring(colonPos + 1);
            }

            return lData;
        }
    }

}