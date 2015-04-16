using System.Timers;

namespace Time_Tracker.Helper
{
    public class TaskTimer
    {
        private Timer SecTimer;

        /// <summary>
        ///  This timer will perform the Action [SetTimerAction for action] every 1 second.
        /// </summary>
        public TaskTimer()
        {
            SecTimer = new Timer(1000);
        }

        /// <summary>
        ///  Set the .Elapsed for the [1s] interval timer.
        /// </summary>
        /// <param name="action">The action to perform each interval.</param>
        public void SetTimerAction(ElapsedEventHandler action)
        {
            SecTimer.Elapsed += action;
        }

        /// <summary>
        ///  Start the timer.
        /// </summary>
        public void StartTimer()
        {
            SecTimer.Start();
        }

        /// <summary>
        ///  Stop the timer.
        /// </summary>
        public void Stoptimer()
        {
            SecTimer.Stop();
        }
    }
}