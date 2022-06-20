using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;
namespace WinAnimationManager
{
    public delegate void OnLoopIterationChanged(Storyboard storyboard, nuint id, int newIterationCount, int oldIterationCount);
    internal class AnimationLoopIterationChangeHandler : IUIAnimationLoopIterationChangeHandler2
    {
        internal OnLoopIterationChanged Handler;
        public void OnLoopIterationChanged(IUIAnimationStoryboard2 storyboard, nuint id, uint newIterationCount, uint oldIterationCount)
        {
            this.Handler?.Invoke(new Storyboard(storyboard), id, (int)newIterationCount, (int)oldIterationCount);
        }
    }
}
