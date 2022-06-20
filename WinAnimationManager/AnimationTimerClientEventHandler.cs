using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    /// <summary>
    /// Handles events that occur when the status of the timer's client changes.
    /// </summary>
    /// <param name="newStatus">
    /// <see cref="UI_ANIMATION_TIMER_CLIENT_STATUS"/>
    /// <list type="bullet">
    /// <item><summary>The client is idle.</summary><code>UI_ANIMATION_TIMER_CLIENT_IDLE = 0</code></item>
    /// <item><summary>The client is busy.</summary><code>UI_ANIMATION_TIMER_CLIENT_BUSY = 1</code></item>
    /// </list>
    /// </param>
    /// <param name="previousStatus">
    /// <see cref="UI_ANIMATION_TIMER_CLIENT_STATUS"/>
    /// <list type="bullet">
    /// <item><summary>The client is idle.</summary><code>UI_ANIMATION_TIMER_CLIENT_IDLE = 0</code></item>
    /// <item><summary>The client is busy.</summary><code>UI_ANIMATION_TIMER_CLIENT_BUSY = 1</code></item>
    /// </list>
    /// </param>
    public delegate void OnTimerClientStatusChanged(int newStatus, int previousStatus);
    internal class AnimationTimerClientEventHandler: IUIAnimationTimerClientEventHandler
    {
        internal event OnTimerClientStatusChanged Handler;
        public void OnTimerClientStatusChanged(UI_ANIMATION_TIMER_CLIENT_STATUS newStatus, UI_ANIMATION_TIMER_CLIENT_STATUS previousStatus)
        {
            this.Handler?.Invoke((int)newStatus, (int)previousStatus);
        }
    }
}
