using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightAPI.UserManagement {
    public class User {

        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Age { get; set; }
        public double BMI { get; set; }

        public List<WeightProgress> WeightProgresses { get; set; }
    }
}
