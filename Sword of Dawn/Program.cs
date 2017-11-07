using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sword_of_Dawn
{
    public class Main
    {
        
        public class Game
        {
          
            static string CharacterName;
            static string AnotherName;

            //Starts the game: prints out game title and overview.
            public static void StartGame()
            {
                Console.WriteLine("Sword of Dawn");
                Console.WriteLine("Welcome to Sword of Dawn, a simple text-based RPG.");
                Console.WriteLine("\r\n");
                NameCharacter();
                FirstSteps();
            }

            //Asks the player for their character name(s) and saves it/them.
            public static void NameCharacter()
            {
                void ProfessionSwitch (string CityName)
                {
                    //Switch case for deciding player's place of birth//
                    switch (CityName)
                    {
                        case "Altdorf":
                            Console.WriteLine("The city of merchants. So tell me: are you a merchant?");
                            Console.WriteLine("\r\n");
                            break;
                        case "Averland":
                            Console.WriteLine("The city of farmers. So tell me: are you a farmer?");
                            Console.WriteLine("\r\n");
                            break;
                        case "Middenheim":
                            Console.WriteLine("The city of knights. So tell me: are you a knight?");
                            Console.WriteLine("\r\n");
                            break;
                        case "Mordheim":
                            Console.WriteLine("The city of adventurers. So tell me: are you an adventurer?");
                            Console.WriteLine("\r\n");
                            break;
                        case "Nuln":
                            Console.WriteLine("The city of soldiers. So tell me: are you a soldier?");
                            Console.WriteLine("\r\n");
                            break;
                        default:
                            Console.WriteLine("That's not a real city! Pick another one.");
                            Console.WriteLine("\r\n");
                            break;

                    }
                }
                Console.WriteLine("What would you like your character's name to be?");
                CharacterName = Console.ReadLine();
                Console.WriteLine("Your character's name is now" + " " + CharacterName + ".");
                Console.WriteLine("\r\n");
                Console.WriteLine("Is this correct?" + " " + "Y" + "/" + "N");
                Console.WriteLine("\r\n");
                //if-then statement for player input on name//
                ConsoleKeyInfo results;
                results = Console.ReadKey();
                if ((results.KeyChar == 'Y') || (results.KeyChar == 'y'))
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Where were you born?");
                    Console.WriteLine("Altdorf" + "\r\n" + "Averland" + "\r\n" + "Middenheim" + "\r\n" + "Mordheim" + "\r\n" + "Nuln" + "\r\n");

                    string CityName = Console.ReadLine();

                    ProfessionSwitch(CityName);
                    
                    //if-else statement for deciding player class. Takes input from Console.ReadLine() and converts it to string, then compares that string against predetermined results.
                    string Profession = Console.ReadLine();
                    if (Profession.Equals("Yes"))
                    {
                        Console.WriteLine("Excellent! Let's begin!");
                    }
                    else if (Profession.Equals("No"))
                    {
                        Console.WriteLine("Pick another one!");
                    }

                }
                else if ((results.KeyChar == 'N') || (results.KeyChar == 'n'))
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Please choose another name.");
                    Console.WriteLine("\r\n");
                    AnotherName = Console.ReadLine();
                    Console.WriteLine("Your character's name is now" + " " + AnotherName + ".");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Where were you born?");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Altdorf" + "\r\n" + "Averland" + "\r\n" + "Middenheim" + "\r\n" + "Mordheim" + "\r\n" + "Nuln" + "\r\n");
                    string CityName = Console.ReadLine();
                    //Switch case for deciding player's place of birth//

                    ProfessionSwitch(CityName);
                    //if-else statement for deciding player class. Takes input from Console.ReadLine().
                    string Profession = Console.ReadLine();
                    if (Profession.Equals("Yes"))
                    {
                        Console.WriteLine("Excellent! Let's begin!");
                    }
                    else if (Profession.Equals("No"))
                    {
                        Console.WriteLine("Pick another one!");
                    }


                }


            }

            public static void FirstSteps()
            {
                //savepoint for code test. need to develop first steps based on profession chosen in NameCharacter().
                Console.ReadLine();
            }

            class Items
            {

            }
            class Program
            {
                static void Main()
                {
                    Game.StartGame();
                }
            }
            
        }
    }

}
//public class City
//{
//    public City()
//    {

//    }
//    public string CityName { get; set; }

//    public Profession Profession { get; set; }


//}
//public class Profession
//{
//    public Profession()
//    {

//    }
//    public string ProfessionName { get; set; }

//    public ICollection<City> City { get; set; }
//}
//public class CityProfessionsContext : DbContext
//{
//    public CityProfessionsContext() : base()
//    {

//    }
//    public DbSet<City> City { get; set; }
//    public DbSet<Profession> Profession { get; set; }
//}