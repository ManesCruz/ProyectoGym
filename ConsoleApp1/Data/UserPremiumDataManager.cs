using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Gym.Logs;

namespace Gym.Data
{
    public static class UserPremiumDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Laura\\source\\repos\\ConsoleApp1\\ConsoleApp1\\Data\\UserPremium.json";
        public static UserPremium AddUserPremium(UserPremium userPremium)
        {
            try
            {
                string currentUserPremiumState = GetFileInfo();
                var jObject = JObject.Parse(currentUserPremiumState);
                userPremium.Id = $"{jObject.Properties().Count() + 1}";
                string userPremiumJson = JsonConvert.SerializeObject(userPremium);
                jObject.Add(userPremium.Id,userPremiumJson);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outputJson);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
            return userPremium;     
        }

        public static UserPremium UpdateUserPremium(UserPremium userPremium) 
        {
            try 
            {
                Logger.LogInformation($"starting update.. {userPremium.Id}");
                string currentUserPremiumState = GetFileInfo();
                var jObject = JObject.Parse(currentUserPremiumState);
                string userPremiumJson = JsonConvert.SerializeObject(userPremium);

                jObject[$"{userPremium.Id}"] = userPremiumJson;

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outputJson);


                return userPremium;
            }
            catch (Exception ex)
            {
              Logger.LogError(ex);
                return null;
            }
        }


        public static bool DeleteUserPremium(string id)
        {
            try
            {
                Logger.LogInformation($"starting deleting.. {id}");
                string currentUserPremiumState = GetFileInfo();
                var jObject = JObject.Parse(currentUserPremiumState);
                jObject.Remove(id);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outputJson);

                return true;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                return false;
            }
        }

        public static UserPremium GetUserPremiumByID(string id) 
        {
            try
            {
                Logger.LogInformation($"starting Getting.. {id}");
                string currentUserPremiumState = GetFileInfo();
                var jObject = JObject.Parse(currentUserPremiumState);
                var userPremiumJsonValue = (string)jObject[id];
                var jObjectValue = JObject.Parse(currentUserPremiumState);

                return new UserPremium(jObjectValue); 
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                return null;
            }
        }


        private static string GetFileInfo() 
        {
        return File.ReadAllText(DATA_FILE);
        }
        private static void WriteFileInfo(string json) 
        { 
            File.WriteAllText(DATA_FILE,json);
        }
    }
}
