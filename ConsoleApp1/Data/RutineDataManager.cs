using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data
{
    public class RutineDataManager
    {
        public static void SaveTime(Rutine PersonalRutine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PersonalRutine.Time);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void UpdateTime(Rutine PersonalRutine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PersonalRutine.Time);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static List<Rutine> GetALL()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            return new List<Rutine>();
        }
        public static Rutine GetTime(string name)
        {
            Rutine PersonalRutine = new Rutine("aerobico", "alta", "1 hora", "3 minutos entre series", "5 dias a la semana");
            return PersonalRutine;
        }
        public static bool DeleteTime(string name)
        {
            Rutine PersonalRutine = new Rutine("aerobico", "alta", "1 hora", "3 minutos entre series", "5 dias a la semana");
            return true;
        }
    }
}
