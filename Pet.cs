using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace VirtualPet {

    
    public class Pet {
        public string name { get; set;}
        public int age { get; set;}
        public int weight { get; set;}
        public int hunger { get; set;}
        public int health { get; set;}
        public int happiness { get; set;}
        public int energy { get; set;}
        public string state { get; set;}
        Random random = new Random();
        

        public Pet(string _name) {
            name = _name;
            age = 0;
            weight = 5;
            hunger = 0;
            health = 10;
            energy = 5;
            happiness = 5;
            state = "fine";
            
        }

        public Pet(string[] stats) {
            name = stats[0];
            age = Int32.Parse(stats[1]);
            weight = Int32.Parse(stats[2]);
            hunger = Int32.Parse(stats[3]);
            health = Int32.Parse(stats[4]);
            energy = Int32.Parse(stats[5]);
            happiness = Int32.Parse(stats[6]);
            state = stats[7];
            
        }

        ~Pet() {
            
        }

        public void Feed() {
            weight = Math.Min(weight + 1, 10);
            hunger = Math.Max(hunger - 2, 0);
            energy = Math.Min(energy + 2, 10);
            Loop();
        }

        public void Play() {
            happiness = Math.Min(happiness + 1, 10);
            energy = Math.Max(energy -1, 0);
            hunger = Math.Min(hunger + 1, 10);
            Loop();
        }

        public void Petting() {
            happiness = Math.Min(happiness + 1, 10);
            Loop();
        }

        public void Walk() {
            weight = Math.Max(weight - 1, 0);
            energy = Math.Max(energy -1, 0);
            hunger = Math.Min(hunger + 1, 10);
            Loop();
        }

        public void Visit() {
            // Not implemented
            Console.WriteLine($"Where would you like to visit with {name}?");
            string option = "0";
            do {
                Console.WriteLine("1) The Park");
                Console.WriteLine("2) The City");
                Console.WriteLine("3) The Vet");
                Console.WriteLine("0) Return home.");
                option = Console.ReadLine();

                switch (option) {
                case "1":
                    Loop();
                    break;
                case "2":
                    Loop();
                    break;
                case "3":
                    Loop();
                    break;
                case "0":
                    break;
                default:
                    break;
            }
            } while (option !="0");            
        }

        public void Nap() {
            do {
                energy = Math.Min(energy + 1, 8);
                    if (happiness > 5) {
                        happiness = Math.Max(happiness - 1, 5);
                    } else {
                        if (happiness < 5) {
                            happiness = Math.Min(happiness +1, 5);
                        } 
                    }
                    Loop();
            } while (energy < 6);
        }

        public void PassTime() {
            happiness = Math.Max(happiness - 1, 0);
            energy = Math.Min(energy + 1, 10);
            Loop();
        }

        public void Loop() {
            age++;
            if (weight > 8 || weight < 2) {
                health = Math.Max(health -1, 0);
            } else {
                health = Math.Min(health +1, 10);
            }
            if (health < 5) {
                //rolling for sickness
                int chance = random.Next(1, 101); // Generates a number between 1 and 100

                if (chance <= 10) {// 10% chance 
                    state = "sick";
                }
            }
            if (state == "sick") {
                Console.WriteLine($"{name} is sick, you should feed them some medicine or head to the vet");
            } else {
                if (happiness <= 3) {
                    Console.WriteLine($"{name} is sad, you should play with them or take them somewhere fun");
                }
            }
            Console.WriteLine("Cycling.");           
        }

        public void Stats() {
                Console.WriteLine($"{name} is currently {state}, they are {age} cycles old.");
                Console.WriteLine($"{name}s stats are as follows:");
                Console.WriteLine("");
                Console.WriteLine($"Weight: {weight}");
                Console.WriteLine($"Hunger: {hunger}");
                Console.WriteLine($"Health: {health}");
                Console.WriteLine($"Happiness: {happiness}");
                Console.WriteLine($"Energy: {energy}");
        }

        
        
    }
}