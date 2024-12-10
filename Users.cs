using System.Collections.Generic;

namespace Game_WFDemo_1202
{
    public static class UserCredentials
    {
        private static Dictionary<string, (string password, bool isCreator)> credentials = new Dictionary<string, (string password, bool isCreator)>()
        {
            { "admin", ("admin123", true) },
            { "duongnguyen", ("duong123", false) }
        };

        public static bool ValidateCredentials(string username, string password, bool isCreator)
        {
            if (credentials.TryGetValue(username, out var storedCredentials))
            {
                return storedCredentials.password == password && storedCredentials.isCreator == isCreator;
            }
            return false;
        }   
    }
}