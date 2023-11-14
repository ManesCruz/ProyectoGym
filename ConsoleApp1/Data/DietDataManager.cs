using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data
{
    public class DietDataManager

    {
        public static void SaveCaloriesNUmber(Diet PersonalDiet)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PersonalDiet.CaloriesNumber);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void UpdateCaloriesNUmber(Rutine PersonalDiet)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PersonalDiet.Time);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static List<Diet> GetALL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            return new List<Diet>();
        }
        public static Diet GetCaloriesNUmber(string name)
        {
            Diet PersonalDiet = new Diet(1200, "Batidos de abano y avena, 3 huevos y arroz", "el dulce", "creatina y proteina en polvo");
            return PersonalDiet;
        }
        public static bool DeleteCaloriesNUmber(string name)
        {
            Diet PersonalDiet = new Diet(1200, "Batidos de abano y avena, 3 huevos y arroz", "el dulce", "creatina y proteina en polvo");
            return true;
        }
    }
}
