using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeightAPI.UserManagement {
    public class AccountGetter {
        public static User CurrentUser;

        public static bool GetAccount(string username) {
            try {
                CurrentUser = JsonConvert.DeserializeObject<User>(File.ReadAllText($"Users/{username}/{username}.sww"));
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

    }
}
