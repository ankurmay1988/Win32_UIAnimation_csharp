using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public delegate void OnValueChangedEventHandler(Storyboard storyboard, AnimationVariable variable, double[] newValue, double[] previousValue);

    internal class AnimationVariableChangeHandler: IUIAnimationVariableChangeHandler2
    {
        internal event OnValueChangedEventHandler Handler;
        public unsafe void OnValueChanged(IUIAnimationStoryboard2 storyboard, IUIAnimationVariable2 variable, double* newValue, double* previousValue, uint cDimension)
        {
            if (this.Handler != null)
            {
                var newValueArr = new double[cDimension];
                Marshal.Copy((IntPtr)newValue, newValueArr, 0, (int)cDimension);
                var previousValueArr = new double[cDimension];
                Marshal.Copy((IntPtr)previousValue, previousValueArr, 0, (int)cDimension);
                this.Handler(new Storyboard(storyboard), new AnimationVariable(variable), newValueArr, previousValueArr);
            }
        }
    }
}
