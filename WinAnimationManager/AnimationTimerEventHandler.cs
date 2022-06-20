using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public delegate bool OnPrePostUpdate();
    public delegate bool OnRenderingTooSlow(uint framesPerSecond);

    internal class AnimationTimerEventHandler: IUIAnimationTimerEventHandler
    {
        internal event OnPrePostUpdate preUpdateHandler;
        internal event OnPrePostUpdate postUpdateHandler;
        internal event OnRenderingTooSlow renderingTooSlowHandler;

        HRESULT IUIAnimationTimerEventHandler.OnPreUpdate()
        {
            var res = preUpdateHandler?.Invoke() ?? false;
            return new HRESULT(res ? 1 : 0);
        }

        HRESULT IUIAnimationTimerEventHandler.OnPostUpdate()
        {
            var res = postUpdateHandler?.Invoke() ?? false;
            return new HRESULT(res ? 1 : 0);
        }

        HRESULT IUIAnimationTimerEventHandler.OnRenderingTooSlow(uint framesPerSecond)
        {
            var res = renderingTooSlowHandler?.Invoke(framesPerSecond) ?? false;
            return new HRESULT(res ? 1 : 0);
        }
    }
}
