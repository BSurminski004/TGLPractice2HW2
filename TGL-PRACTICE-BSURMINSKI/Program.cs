using TGL_PRACTICE_BSURMINSKI.CHARACTERS;

namespace TGL_PRACTICE_BSURMINSKI
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Boxing Manager 2022\nPress any key to start..");
            Console.ReadLine(); Console.Clear();
            Player f1 = new Player();
            Player f2 = new Player();
            Referee r1 = new Referee();
            Greet(1);
            fighterInfo(f1);
            Greet(2);
            fighterInfo(f2);
            fightersIntro(f1, f2);

            
        }



        public static void fighterInfo(Player fighter1)
        {
            try {
                Console.WriteLine("Fill your fighter name: ");
                fighter1.Name = Console.ReadLine();
                Console.WriteLine("Fill your fighter surname: ");
                fighter1.Surname = Console.ReadLine();
                Console.WriteLine("Fill your fighter nickname: ");
                fighter1.Nickname = Console.ReadLine();
                Console.WriteLine("Fill your fighter height[cm]: ");
                fighter1.Height = double.Parse(Console.ReadLine());
                Console.WriteLine("Fill your fighter weight[kg]: ");
                fighter1.Weight = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (System.FormatException) { Console.WriteLine("Bad Input!!"); }
            
        }

        public static void fightersIntro(Player f, Player f2)
        {
            Console.WriteLine("Fighters info:");
            Console.WriteLine($"First fighter:{f.Name} {f.Surname} --aka {f.Nickname}\nWeight:{f.Weight}[kg]\nHeight:{f.Height}[cm]\n");
            Console.WriteLine($"Second fighter:{f2.Name} {f2.Surname} --aka {f2.Nickname}\nWeight:{f2.Weight}[kg]\nHeight:{f2.Height}[cm]");

        }

        public static void Greet(int i)
        {
         string a = i==1?  "Firstly insert your first player data!": "Now insert second fighter data!";
            Console.WriteLine(a);
        }
    }
}