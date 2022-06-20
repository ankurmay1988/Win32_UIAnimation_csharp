using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public class AnimationTimer : IAnimationTimer
    {
        internal IUIAnimationTimer _timer;
        internal AnimationTimer(IUIAnimationTimer timer)
        {
            _timer = timer;
        }

        public void Disable()
        {
            _timer.Disable();
        }

        public void Enable()
        {
            _timer.Enable();
        }

        public void GetTime(out double seconds)
        {
            _timer.GetTime(out seconds);
        }

        public void IsEnabled()
        {
            _timer.IsEnabled();
        }

        public void SetFrameRateThreshold(uint framesPerSecond)
        {
            _timer.SetFrameRateThreshold(framesPerSecond);
        }
    }
}
