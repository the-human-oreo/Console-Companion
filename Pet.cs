using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace VirtualPet {
    public class Pet {
        public string name { get; private set;}
        public int age { get; private set;}
        public int weight { get; private set;}
        public int hunger { get; private set;}
        public int health { get; private set;}
        public int happiness { get; private set;}
        public int energy { get; private set;}
        public string state { get; private set;}
        

        public Pet(string _name) {
            name = _name;
            age = 0;
            weight = 5;
            hunger = 0;
            health = 10;
            energy = 5;
            happiness = 5;
            state = "Shocked";
            
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

        public void Walk() {
            weight = Math.Max(weight - 1, 0);
            energy = Math.Max(energy -1, 0);
            hunger = Math.Min(hunger + 1, 10);
            Loop();
        }

        public void Visit() {
            // Not implemented
            Loop();
        }

        public void Nap() {
            energy = Math.Min(energy + 1, 10);
            happiness = Math.Max(happiness - 1, 0);
            Loop();
        }

        public void PassTime() {
            happiness = Math.Max(happiness - 1, 0);
            energy = Math.Min(energy + 1, 10);
            Loop();
        }

        public void Loop() {
            age++;
            if (age > 5) {
                state = "Accepting";
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