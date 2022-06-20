using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public delegate void OnIntegerValueChangedEventHandler(Storyboard storyboard, AnimationVariable variable, int[] newValue, int[] previousValue);

    internal class AnimationVariableIntegerChangeHandler: IUIAnimationVariableIntegerChangeHandler2
    {
        internal event OnIntegerValueChangedEventHandler Handler;
        public unsafe void OnIntegerValueChanged(IUIAnimationStoryboard2 storyboard, IUIAnimationVariable2 variable, int* newValue, int* previousValue, uint cDimension)
        {
            if (this.Handler != null)
            {
                var newValueArr = new int[cDimension];
                Marshal.Copy((IntPtr)newValue, newValueArr, 0, (int)cDimension);
                var previousValueArr = new int[cDimension];
                Marshal.Copy((IntPtr)previousValue, previousValueArr, 0, (int)cDimension);
                this.Handler(new Storyboard(storyboard), new AnimationVariable(variable), newValueArr, previousValueArr);
            }
        }
    }
}
