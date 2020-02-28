using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeightAPI.UserManagement {
    public static class AccountCreator {

        /// <summary>
        /// Throws a not implemented yet
        /// </summary>
        public static void CreateAccount(string name, string userName, double weight, double height, double age, double bmi) {
            throw new NotImplementedException();
        }

        //Todo: add height
        //Todo: password encryption
        public static bool CreateAccount(string name, string userName, string password, double weight, double age) {
            User user = new User() {
                Name = name,
                UserName = userName,
                Password = password,
                Weight = weight,
                Height = 0,
                Age = age,
                BMI = 0,
                WeightProgresses = new List<WeightProgress>()
            };

            if (!Directory.Exists($"Users/{userName}")) {
                Directory.CreateDirectory($"Users/{userName}");
                File.WriteAllText($"Users/{userName}/{userName}.sww", JsonConvert.SerializeObject(user));
                return true;
            }

            return false;
        }
    }
}
