using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data
{
    public class RegularUserDataManager
    {
        public static void SaveWeight(RegularUser Weight)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Weight.Weight);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void UpdateWeight(RegularUser Weight)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Weight.Weight);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static List<RegularUser> GetALL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            return new List<RegularUser>();
        }
        public static RegularUser GetWeight(double name)
        {
            RegularUser Weight = new RegularUser("Manuel Esteban Cruz Parra", 17, 1.85, 65, "elevate", "crecer", "masculine", "Kilos");
            return Weight;
        }
        public static bool DeleteWeight(string name)
        {
            RegularUser Weight= new RegularUser("Manuel Esteban Cruz Parra", 17, 1.85, 65, "elevate", "crecer", "masculine", "Kilos");
            return true;
        }

    }
}
