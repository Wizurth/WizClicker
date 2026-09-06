using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace WizClicker
{
//#############################################################################
//##--------------------------------- CLASS ---------------------------------##
//#############################################################################

internal static class Config
{
//#############################################################################
//##--------------------------------- FIELDS --------------------------------##
//#############################################################################

    private static string ConfigFileFullPath = Path.Combine(WAppSettings.LocalDataFolderPath, WAppSettings.ConfigFileName);
    private static string LogsFileFullPath   = Path.Combine(WAppSettings.LocalDataFolderPath, WAppSettings.LogsFileName);

    public struct AppConfig
    {
        public Keys FireKey { get; set; }
        public Keys SimKey { get; set; }
        public int Cps { get; set; }

        public bool IsDefault()
            => (FireKey == WAppSettings.DefaultFireKey && SimKey == WAppSettings.DefaultSimKey && Cps == WAppSettings.DefaultCps);

        public bool IsValid()
            => (Cps > 0 && Cps <= WAppSettings.MaxCps);
    }

//#############################################################################
//##-------------------------------- METHODS --------------------------------##
//#############################################################################

    public static AppConfig UpdateConfig(Keys InFireKey, Keys InSimKey, int InCps)
    {
        // Make sure to config folder existing
        if (!Directory.Exists(WAppSettings.LocalDataFolderPath))
        {
            Directory.CreateDirectory(WAppSettings.LocalDataFolderPath);
        }

        // Creating appsetting object
        AppConfig ConfigObject = new AppConfig
        {
            FireKey = InFireKey,
            SimKey  = InSimKey,
            Cps     = InCps
        };

        // Write into a JSON file
        string json_write = JsonConvert.SerializeObject(ConfigObject, Formatting.Indented);
        File.WriteAllText(Path.Combine(WAppSettings.LocalDataFolderPath, WAppSettings.ConfigFileName), json_write);

        WriteLog("The configuration file has been written.");
        WriteLog("The new values are:");
        WriteLog("FireKey = " + InFireKey);
        WriteLog("SimKey = " + InSimKey);
        WriteLog("CPS = " + InCps);

        return ConfigObject;
    }

    public static AppConfig ExtractConfig()
    {
        AppConfig ConfigObject;

        WriteLog("Retrieving the configuration file from the location: " + ConfigFileFullPath);

        // Vérifie si le fichier existe
        if (File.Exists(Path.Combine(WAppSettings.LocalDataFolderPath, WAppSettings.ConfigFileName)))
        {
            string JsonFileExtracted = File.ReadAllText(ConfigFileFullPath);

            // Config cannot be read -> set null to reset all values and write a new config
            try
            {
                ConfigObject = JsonConvert.DeserializeObject<AppConfig>(JsonFileExtracted);
                if (ConfigObject.IsValid())
                {
                    return ConfigObject;
                }
            }
            catch
            {
                // ignored -> config reset bellow
            }
        }

        WriteLog("Error: Unable to read configuration file, file has been reset.");
        return UpdateConfig(WAppSettings.DefaultFireKey, WAppSettings.DefaultSimKey, WAppSettings.DefaultCps); // Write the default config
    }

    public static void WriteLog(string Log) //Logs
    {
        string LogWithTime = DateTime.Now.ToString("[dd-MM-yyyy:HH:mm:sstt]=>") + Log + Environment.NewLine;
        if (File.Exists(LogsFileFullPath))
        {
            File.AppendAllText(LogsFileFullPath, LogWithTime);
        }
        else
        {
            File.WriteAllText(LogsFileFullPath, LogWithTime);
        }
    }
}
}