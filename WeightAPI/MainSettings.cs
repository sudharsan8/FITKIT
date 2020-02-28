using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeightAPI {
    public class MainSettings {
        private DefaultSettings _defaultSettings;

        private static readonly Lazy<MainSettings> Lazy = new Lazy<MainSettings>(() => new MainSettings());
        public static MainSettings InstanceMainSettings => Lazy.Value;
        private MainSettings() { }

        #region Default Settings

        public void StartDefaultSettings() => _defaultSettings = JsonConvert.DeserializeObject<DefaultSettings>(File.ReadAllText("default.settings"));

        public void SaveDefaultSettings() {
            try {
                File.Delete("default.settings");
                File.WriteAllText("default.settings", JsonConvert.SerializeObject(_defaultSettings));
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        public bool GetAutoLogin => _defaultSettings.AutoLogin;
        public string GetLastUsername => _defaultSettings.LastUserName;
        #endregion

        #region User Settings

        //Todo: implement
        public void StartUserSettings() {
            throw new NotImplementedException();
        }

        //Todo: implement
        public void SaveUserSettings() {
            throw new NotImplementedException();
        }

        #endregion





    }
}
