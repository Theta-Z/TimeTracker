using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Time_Tracker.Helper;

namespace Time_Tracker.Forms.Settings
{
    public class FormSettings : IFormSettings
    {
        public readonly string FileName;
        public readonly string FilePath;
        private SettingsObject Settings;

        public FormSettings(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
            Settings = new SettingsObject();
            Settings.BGColour = Color.FromKnownColor(KnownColor.ControlDark);
            Settings.FGColour = Color.Black;
            LoadSettings();
        }

        public Color GetBGColour()
        {
            return Settings.BGColour;
        }

        public Color GetFGColour()
        {
            return Settings.FGColour;
        }

        public void LoadSettings()
        {
            if (!Directories.LocalFileExists(string.Format(@"{0}\{1}", FilePath, FileName)))
                return;

            var fileContents = string.Empty;
            using (var sr = new StreamReader(string.Format(@"{0}\{1}", FilePath, FileName)))
            {
                fileContents = sr.ReadToEnd();
                sr.Close();
            }

            Settings = JsonConvert.DeserializeObject<SettingsObject>(fileContents);
        }

        public void SaveSettings()
        {
            Directories.CreateLocalDirectoryIfNotExists(FilePath);

            using (var sw = new StreamWriter(string.Format(@"{0}\{1}", FilePath, FileName)))
            {
                sw.Write(JsonConvert.SerializeObject(Settings));
                sw.Close();
            }
        }

        public void SetBGColour(Color c)
        {
            Settings.BGColour = c;
            SaveSettings();
        }

        public void SetFGColour(Color c)
        {
            Settings.FGColour = c;
            SaveSettings();
        }
    }
}