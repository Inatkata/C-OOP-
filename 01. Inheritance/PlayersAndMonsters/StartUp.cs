using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main()
        {
            var darkWizard = new DarkWizard("Dark", 4);
            Console.WriteLine(darkWizard);
        }
    }
}