using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public class TransitionLibrary: ITransitionLibrary
    {
        internal IUIAnimationTransitionLibrary2 _animationLibrary;

        internal TransitionLibrary(IUIAnimationTransitionLibrary2 animationLibrary)
        {
            this._animationLibrary = animationLibrary;
        }

        public AnimationTransition CreateAccelerateDecelerateTransition(double duration, double finalValue, double accelerationRatio, double decelerationRatio)
        {
            _animationLibrary.CreateAccelerateDecelerateTransition(duration, finalValue, accelerationRatio, decelerationRatio, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateConstantTransition(double duration)
        {
            _animationLibrary.CreateConstantTransition(duration, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateCubicBezierLinearTransition(double duration, double finalValue, double x1, double y1, double x2, double y2)
        {
            _animationLibrary.CreateCubicBezierLinearTransition(duration, finalValue, x1, y1, x2, y2, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateCubicBezierLinearVectorTransition(double duration, double[] finalValue, double x1, double y1, double x2, double y2)
        {
            _animationLibrary.CreateCubicBezierLinearVectorTransition(duration, finalValue, x1, y1, x2, y2, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateCubicTransition(double duration, double finalValue, double finalVelocity)
        {
            _animationLibrary.CreateCubicTransition(duration, finalValue, finalVelocity, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateCubicVectorTransition(double duration, double[] finalValue, double[] finalVelocity)
        {
            _animationLibrary.CreateCubicVectorTransition(duration, finalValue, finalVelocity, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateDiscreteTransition(double delay, double finalValue, double hold)
        {
            _animationLibrary.CreateDiscreteTransition(delay, finalValue, hold, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateDiscreteVectorTransition(double delay, double[] finalValue, double hold)
        {
            _animationLibrary.CreateDiscreteVectorTransition(delay, finalValue, hold, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateInstantaneousTransition(double finalValue)
        {
            _animationLibrary.CreateInstantaneousTransition(finalValue, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateInstantaneousVectorTransition(double[] finalValue)
        {
            _animationLibrary.CreateInstantaneousVectorTransition(finalValue, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateLinearTransition(double duration, double finalValue)
        {
            _animationLibrary.CreateLinearTransition(duration, finalValue, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateLinearTransitionFromSpeed(double speed, double finalValue)
        {
            _animationLibrary.CreateLinearTransitionFromSpeed(speed, finalValue, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateLinearVectorTransition(double duration, double[] finalValue)
        {
            _animationLibrary.CreateLinearVectorTransition(duration, finalValue, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateLinearVectorTransitionFromSpeed(double speed, double[] finalValue)
        {
            _animationLibrary.CreateLinearVectorTransitionFromSpeed(speed, finalValue, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateParabolicTransitionFromAcceleration(double finalValue, double finalVelocity, double acceleration)
        {
            _animationLibrary.CreateParabolicTransitionFromAcceleration(finalValue, finalVelocity, acceleration, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateReversalTransition(double duration)
        {
            _animationLibrary.CreateReversalTransition(duration, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateSinusoidalTransitionFromRange(double duration, double minimumValue, double maximumValue, double period, int slope)
        {
            _animationLibrary.CreateSinusoidalTransitionFromRange(duration, minimumValue, maximumValue, period, (UI_ANIMATION_SLOPE)slope, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateSinusoidalTransitionFromVelocity(double duration, double period)
        {
            _animationLibrary.CreateSinusoidalTransitionFromVelocity(duration, period, out var transition);
            return new AnimationTransition(transition);
        }

        public AnimationTransition CreateSmoothStopTransition(double maximumDuration, double finalValue)
        {
            _animationLibrary.CreateSmoothStopTransition(maximumDuration, finalValue, out var transition);
            return new AnimationTransition(transition);
        }
    }
}