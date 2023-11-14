using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data
{
    public class ExerciseDataManager
    {
        public static void SaveMovement(Exercise FlexionesRusas)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FlexionesRusas.Movement);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void UpdateMovement(Exercise FlexionesRusas)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FlexionesRusas.Movement);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static List<Exercise> GetALL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            return new List<Exercise>();
        }
        public static Exercise GetMovement(string name)
        {
            Exercise FlexionesRusas = new Exercise("flexiones rusas", 3, 12, "subir y bajar", 0, "colchoneta");
            return FlexionesRusas;
        }
        public static bool DeleteMovement(string name)
        {
            Exercise FlexionesRusas= new Exercise("flexiones rusas", 3, 12, "subir y bajar", 0, "colchoneta");
            return true;
        }
    }
}
