namespace VirtualPet {
    class ParkLocation : LocationInterface {
        Random random = new Random();
        public void Visit(Pet pet)
        {
            Console.WriteLine($"You visited the park with {pet.name}");
            if (random.Next(1, 101) <= 10) {
                pet.health = Math.Min(pet.health +1, 7);
            }
            if (random.Next(1, 101) <= 10) {
                pet.happiness = Math.Min(pet.happiness +1, 10);
                Console.WriteLine($"{pet.name} played with other pets and seems to have enjoyed themselves.");
            }
            pet.happiness = Math.Min(pet.happiness +2, 10);
            Console.WriteLine($"{pet.name} had fun at the park.");      
            pet.energy = Math.Max(pet.energy -2, 0);
            Console.WriteLine($"{pet.name} is all tired out.");      
        }
    }

    class CityLocation : LocationInterface {
        Random random = new Random();
        public void Visit(Pet pet)
        {
            Console.WriteLine($"You visited the city with {pet.name}");
            if (random.Next(1, 101) <= 1) {
                pet.state = "sick";
                Console.WriteLine($"{pet.name} got sick in the city, you should feed them some medicine or head to the vet");
            }
            pet.happiness = Math.Min(pet.happiness +1, 10);      
            pet.energy = Math.Max(pet.energy -1, 0);     
        }
    }

    class VetLocation : LocationInterface {
        Random random = new Random();
        public void Visit(Pet pet)
        {
            Console.WriteLine($"You visited the vet with {pet.name}");
            if (pet.state == "sick") {
                pet.state = "healthy";
                Console.WriteLine($"{pet.name} feels better now.");
            }
        
            if (pet.weight > 7) {
                Console.WriteLine($"{pet.name} is a bit overweight, maybe walk/play with them some more.");
            } else if (pet.weight < 3) {
                Console.WriteLine($"{pet.name} is a bit underweight, maybe let them rest and feed them some more.");
            }
            pet.health = Math.Min(pet.health +5, 10);
            Console.WriteLine($"{pet.name} was given a checkup and should now be healthier.");

            pet.happiness = Math.Max(pet.happiness -1, 0);
            Console.WriteLine($"{pet.name} did not like their visit to the vet.");
        }
    }
}
