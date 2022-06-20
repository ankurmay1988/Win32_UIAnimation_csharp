using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public delegate void OnCurveChangedEventHandler(AnimationVariable variable);

    internal class AnimationVariableCurveChangeHandler: IUIAnimationVariableCurveChangeHandler2
    {
        internal event OnCurveChangedEventHandler Handler;
        public void OnCurveChanged(IUIAnimationVariable2 variable)
        {
            this.Handler?.Invoke(new AnimationVariable(variable));
        }
    }
}
