using System;
using System.IO;
using System.Windows.Input;
using Newtonsoft.Json;

namespace WizClicker
{
    internal class Config
    {
        public static string location => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"WizProductions\WizClicker\");
        static string filename = "WizAppSettings.json";

        public static void Update(Key saved_key, int saved_cps)
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

        public static AppConfig Extract()
        {
            // Vérifie si le fichier existe
            if (File.Exists(Path.Combine(location, filename)))
            {
                // Lit le contenu du fichier JSON
                string json = File.ReadAllText(Path.Combine(location, filename));

                // Désérialise le JSON en un objet AppSettings
                AppConfig config = JsonConvert.DeserializeObject<AppConfig>(json);
                return config;
            }
            else
            {
                Console.WriteLine("Le fichier JSON n'existe pas.");
                return null;
            }
        }
        public class AppConfig
        {
            public Key SavedKey { get; set; }
            public int SavedCps { get; set; }
        }
    }
}
