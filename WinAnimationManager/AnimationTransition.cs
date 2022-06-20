using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public class AnimationTransition: IAnimationTransition
    {
        internal IUIAnimationTransition2 _transition;

        internal AnimationTransition(IUIAnimationTransition2 transition)
        {
            this._transition = transition;
        }

        public uint GetDimension()
        {
            _transition.GetDimension(out var dimenstion);
            return dimenstion;
        }

        public double GetDuration()
        {
            _transition.GetDuration(out var duration);
            return duration;
        }

        public void IsDurationKnown()
        {
            _transition.IsDurationKnown();
        }

        public void SetInitialValue(double value)
        {
            _transition.SetInitialValue(value);
        }

        public void SetInitialVectorValue(double[] value)
        {
            _transition.SetInitialVectorValue(value);
        }

        public void SetInitialVectorVelocity(double[] velocity)
        {
            _transition.SetInitialVectorVelocity(velocity);
        }

        public void SetInitialVelocity(double velocity)
        {
            _transition.SetInitialVelocity(velocity);
        }
    }
}