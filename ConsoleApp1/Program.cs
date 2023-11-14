using Microsoft.VisualBasic;
using Gym.Data;
using System.Security;

namespace Gym
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,World");
            UserPremium userPremium = new UserPremium("Manuel Esteban Cruz Parra", 17, 1.85, 65, "elevate", "crecer", "masculine", "Kilos");
            UserPremiumDataManager.AddUserPremium(userPremium);

            var userPremiumUpd = UserPremiumDataManager.UpdateUserPremium(userPremium);
            userPremiumUpd.Name += " Update";
            UserPremiumDataManager.UpdateUserPremium(userPremiumUpd);

            UserPremiumDataManager.DeleteUserPremium("3");
        
             var getUserPremium = UserPremiumDataManager.GetUserPremiumByID("1");



            /*RegularUser Weight = new RegularUser("Manuel Esteban Cruz Parra", 17, 1.85, 65, "elevate", "crecer", "masculine", "Kilos");
            Console.WriteLine(Weight.Weight);

            Rutine PersonalRutine = new Rutine("aerobico", "alta", "1 hora", "3 minutos entre series", "5 dias a la semana");
            Console.WriteLine(PersonalRutine.Time);

            Diet PersonalDiet = new Diet(1200, "Batidos de abano y avena, 3 huevos y arroz","el dulce","creatina y proteina en polvo");
            Console.WriteLine(PersonalDiet.CaloriesNumber);

            Exercise FlexionesRusas = new Exercise("flexiones rusas", 3, 12, "subir y bajar", 0, "colchoneta");
            Console.WriteLine(FlexionesRusas.ExerciseName);

            Exercise sentadillas = new Exercise("sentadillas", 3, 12, "subir y bajar", 0, "colchoneta");
            Console.WriteLine(sentadillas.ExerciseName);

            Exercise[] ejercicios = new Exercise[] { FlexionesRusas, sentadillas };


*/
        }
    }
}