using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Input;

namespace WizClicker
{
    internal class Config
    {
        public static string location => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"WizProductions\WizClicker\");
        static string filename = "WizAppSettings.json";
        static string logsfilename = "WizAppLogs.txt";

        public static void Update(System.Windows.Input.Key saved_key, int saved_cps, bool by_sys)
        {
            // Make sure to config folder existing
            if (!Directory.Exists(location))
            {
                Directory.CreateDirectory(location);
            }

            // Creating appsetting object
            AppConfig config = new AppConfig
            {
                SavedKey = saved_key,
                SavedCps = saved_cps
            };

            // Write into json
            string json_write = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(Path.Combine(location, filename), json_write);
            if(by_sys != true)
            {
                WriteInLogs("The configuration file has been updated by the user.");
                WriteInLogs("The new values are:");
                WriteInLogs("Key = " + saved_key);
                WriteInLogs("CPS = " + saved_cps);
            }
        }

        public static AppConfig Extract(System.Windows.Forms.ComboBox keylistComboBox, int maxCPS)
        {
            AppConfig config = null;

            // Vérifie si le fichier existe
            if (File.Exists(Path.Combine(location, filename)))
            {
                // Lit le contenu du fichier JSON
                string json = File.ReadAllText(Path.Combine(location, filename));

                try //CHECK VALIDITY OF CONFIG FILE
                {
                    config = JsonConvert.DeserializeObject<AppConfig>(json); //TRY TO READ AND CONVERT FILE    |     // Désérialise le JSON en un objet AppSettings
                }
                catch //CANNOT READ => RESET VALUE
                {
                    config = null;
                }

                if (config !=null && config.SavedCps <= maxCPS && config.SavedCps > 0 && keylistComboBox.Items.Contains(config.SavedKey)) //CONFIG IS VALID
                {
                    return config;
                }
                else
                {
                    Update((System.Windows.Input.Key)keylistComboBox.Items[0], 1, true);
                    json = File.ReadAllText(Path.Combine(location, filename));
                    config = JsonConvert.DeserializeObject<AppConfig>(json);
                    WriteInLogs("Error: unable to read configuration file, file has been reset.");

                    return config;
                }
            }
            else
            {
                // Make sure to config folder existing
                if (!Directory.Exists(location))
                {
                    Directory.CreateDirectory(location);
                }

                WriteInLogs("Retrieving the configuration file from this location: " + location + filename);
                WriteInLogs("Error: the configuration file cannot be found.");
                WriteInLogs("Write the configuration file...");

                Update((System.Windows.Input.Key)keylistComboBox.Items[0], 1, true);
                config = JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(Path.Combine(location, filename)));

                WriteInLogs("The configuration file has been written.");
                return config;
            }
        }

        public static void WriteInLogs(string logs_write) //Logs
        {
            string logs_convert = DateTime.Now.ToString("[dd-MM-yyyy:HH:mm:sstt]=>") + logs_write + Environment.NewLine;
            if (File.Exists(Path.Combine(location, logsfilename)))
            { File.AppendAllText(Path.Combine(location, logsfilename), logs_convert); }
            else
            { File.WriteAllText(Path.Combine(location, logsfilename), logs_convert); }
        }


        public class AppConfig
        {
            public System.Windows.Input.Key SavedKey { get; set; }
            public int SavedCps { get; set; }
        }
    }
}
