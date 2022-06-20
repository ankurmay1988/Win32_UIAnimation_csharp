using System;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public delegate bool OnAnimationTimerUpdate(double timeNow, int result);

    internal class AnimationTimerUpdateEventHandler : IUIAnimationTimerUpdateHandler
    {
        private IUIAnimationTimerClientEventHandler _animationTimer;

        internal event OnTimerClientStatusChanged onTimerClientStatusChanged;
        internal event OnAnimationTimerUpdate onAnimationTimerUpdate;

        public unsafe HRESULT OnUpdate(double timeNow, UI_ANIMATION_UPDATE_RESULT* result)
        {
            var res = this.onAnimationTimerUpdate?.Invoke(timeNow, (int)*result) ?? false;
            return new HRESULT(res ? 0 : 1);
        }

        public HRESULT SetTimerClientEventHandler(IUIAnimationTimerClientEventHandler handler)
        {
            return new HRESULT(0);
        }

        public HRESULT ClearTimerClientEventHandler()
        {
            return new HRESULT(0);
        }

        //public CustomQueryInterfaceResult GetInterface(ref Guid iid, out IntPtr ppv)
        //{
        //    ppv = IntPtr.Zero;
        //    if (iid == typeof(IUIAnimationTimerUpdateHandler).GUID)
        //    {
        //        ppv = Marshal.GetComInterfaceForObject(this, typeof(IUIAnimationTimerUpdateHandler),
        //            CustomQueryInterfaceMode.Ignore);
        //        return CustomQueryInterfaceResult.Handled;
        //    }
        //    return CustomQueryInterfaceResult.NotHandled;
        //}
    }
}