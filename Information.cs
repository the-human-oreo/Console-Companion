namespace VirtualPet {
    public class InfoMenu {
        public void menu() {
            Console.WriteLine("**** Information ****");
            Console.WriteLine("");
            Console.WriteLine("Welcome to ConsoleCompanion.");
            Console.WriteLine("The lite console game was developed by me learning the basics of object oriented programming.");
            Console.WriteLine("");
            Console.WriteLine("What information would you like to know?");
        }

        public void Instructions() {
            Console.WriteLine("");
            Console.WriteLine("**** Instructions ****");
            Console.WriteLine("");
            Console.WriteLine("Each menu will have listed options, numbered 0 through 9.");
            Console.WriteLine("To choose an option simply enter the number and hit enter.");
            Console.WriteLine("Basically, what you've already been doing.");
            Console.WriteLine("Also, save files are currently located in your 'My Documents' folder ");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            //Console.SetCursorPosition(0, Console.GetCursorPosition());
            Console.WriteLine("");
        }

        public void Creator() {
            Console.WriteLine("");
            Console.WriteLine("**** My Info ****");
            Console.WriteLine("");
            Console.WriteLine("My name is Oliver and I'm the creator of this game.");
            Console.WriteLine("As mentioned earlier, very simple, very basic, used to learn C#.");
            Console.WriteLine("One day I hope to recreate this into a larger, not console based, project.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}