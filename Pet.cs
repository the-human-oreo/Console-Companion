using System;

namespace VirtualPet {
    public class Pet {
        public string Name { get; private set;}
        public int Age { get; private set;}
        public int Weight { get; private set;}
        public int Hunger { get; private set;}
        public int Health { get; private set;}
        public int Happiness { get; private set;}
        public int Energy { get; private set;}
        public string State { get; private set;}

        public Pet(string name) {
            Name = name;
            Age = 0;
            Weight = 5;
            Hunger = 0;
            Health = 10;
            Energy = 5;
            Happiness = 5;
            State = "Shocked";
        }

        public Pet(string[] stats) {
            Name = stats[0];
            Age = Int32.Parse(stats[1]);
            Weight = Int32.Parse(stats[2]);
            Hunger = Int32.Parse(stats[3]);
            Health = Int32.Parse(stats[4]);
            Energy = Int32.Parse(stats[5]);
            Happiness = Int32.Parse(stats[6]);
            State = stats[7];
        }

        ~Pet() {
            Console.WriteLine($"{Name} will be waiting here for you.");

        }

        public void Feed() {
            Weight = Math.Min(Weight + 1, 10);
            Hunger = Math.Max(Hunger - 2, 0);
            Energy = Math.Min(Energy + 2, 10);
            Loop();
        }

        public void Play() {
            Happiness = Math.Min(Happiness + 1, 10);
            Energy = Math.Max(Energy -1, 0);
            Loop();
        }

        public void Walk() {
            Weight = Math.Max(Weight - 1, 0);
            Energy = Math.Max(Energy -1, 0);
            Loop();
        }

        public void Visit() {
            Loop();
        }

        public void Nap() {
            Energy = Math.Min(Energy + 1, 10);
            Loop();
        }

        public void PassTime() {
            Happiness = Math.Max(Happiness - 1, 0);
            Energy = Math.Min(Energy + 1, 10);
            Loop();
        }

        public void Loop() {
            Age++;
            if (5 > Age && Age > 1) {
                State = "Accepting";
            }
        }
        
    }
}