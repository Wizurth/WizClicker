using System;
using System.IO;
using Newtonsoft.Json;

namespace WizClicker
{
    internal class Config
    {
        public static string location => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"WizProductions\WizClicker\");
        static string filename = "WizAppSettings.json";
        static string logsfilename = "WizAppLogs.txt";

        public static void Update(System.Windows.Input.Key saved_key, int saved_cps)
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
        }

        public static AppConfig Extract(System.Windows.Forms.ComboBox keylistComboBox, int maxCPS)
        {

            // Vérifie si le fichier existe
            if (File.Exists(Path.Combine(location, filename)))
            {
                // Lit le contenu du fichier JSON
                string json = File.ReadAllText(Path.Combine(location, filename));

                // Désérialise le JSON en un objet AppSettings
                AppConfig config = JsonConvert.DeserializeObject<AppConfig>(json);

                if (config.SavedCps <= maxCPS && config.SavedCps > 0 && keylistComboBox.Items.Contains(config.SavedKey)) //CONFIG IS VALID
                { return config; }
                else
                {
                    Update((System.Windows.Input.Key)keylistComboBox.Items[0], 1);
                    json = File.ReadAllText(Path.Combine(location, filename));
                    config = JsonConvert.DeserializeObject<AppConfig>(json);
                    WriteInLogs("Erreur : Le fichier de configuration a été compromis, il a donc été réinitialisé.");

                    return config;
                }
            }
            else
            {
                Console.WriteLine("Le fichier JSON n'existe pas.");
                return null;
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
