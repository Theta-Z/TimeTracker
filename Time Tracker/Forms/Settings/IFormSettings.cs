using System.Drawing;

namespace Time_Tracker.Forms.Settings
{
    public interface IFormSettings
    {
        Color GetBGColour();

        Color GetFGColour();

        void LoadSettings();

        void SaveSettings();

        void SetBGColour(Color c);

        void SetFGColour(Color c);
    }
}