using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public class AnimationVariable: IAnimationVariable 
    {
        internal IUIAnimationVariable2 _variable;

        internal AnimationVariable(IUIAnimationVariable2 variable)
        {
            this._variable = variable;
        }

        public void SubscribeToVariableChangeEvent(OnValueChangedEventHandler handler, bool registerForNextAnimationEvent = true)
        {
            var _handler = new AnimationVariableChangeHandler();
            _handler.Handler += handler;
            _variable.SetVariableChangeHandler(_handler, registerForNextAnimationEvent);
        }

        public void SubscribeToCurveChangeEvent(OnCurveChangedEventHandler handler)
        {
            var _handler = new AnimationVariableCurveChangeHandler();
            _handler.Handler += handler;
            _variable.SetVariableCurveChangeHandler(_handler);
        }

        public void SubscribeToVariableIntegerChangeEvent(OnIntegerValueChangedEventHandler handler, bool registerForNextAnimationEvent = true)
        {
            var _handler = new AnimationVariableIntegerChangeHandler();
            _handler.Handler += handler;
            _variable.SetVariableIntegerChangeHandler(_handler, registerForNextAnimationEvent);
        }

        public double[] GetVectorValue()
        {
            var vec = new double[GetDimension()];
            _variable.GetVectorValue(vec);
            return vec;
        }

        public uint GetDimension()
        {
            _variable.GetDimension(out var d);
            return d;
        }

        public double GetValue()
        {
            _variable.GetValue(out var d);
            return d;
        }

        public double GetFinalValue()
        {
            _variable.GetFinalValue(out var d);
            return d;
        }

        public double[] GetFinalVectorValue()
        {
            var vec = new double[GetDimension()];
            _variable.GetFinalVectorValue(vec);
            return vec;
        }

        public double GetPreviousValue()
        {
            _variable.GetPreviousValue(out var d);
            return d;
        }

        public double[] GetPreviousVectorValue()
        {
            var vec = new double[GetDimension()];
            _variable.GetPreviousVectorValue(vec);
            return vec;
        }

        public int GetIntegerValue()
        {
            _variable.GetIntegerValue(out var d);
            return d;
        }

        public int[] GetIntegerVectorValue()
        {
            var vec = new int[GetDimension()];
            _variable.GetIntegerVectorValue(vec);
            return vec;
        }

        public int GetFinalIntegerValue()
        {
            _variable.GetFinalIntegerValue(out var d);
            return d;
        }

        public int[] GetFinalIntegerVectorValue()
        {
            var vec = new int[GetDimension()];
            _variable.GetFinalIntegerVectorValue(vec);
            return vec;
        }

        public int GetPreviousIntegerValue()
        {
            _variable.GetPreviousIntegerValue(out var d);
            return d;
        }

        public int[] GetPreviousIntegerVectorValue()
        {
            var vec = new int[GetDimension()];
            _variable.GetPreviousIntegerVectorValue(vec);
            return vec;
        }

        public Storyboard GetCurrentStoryboard()
        {
            _variable.GetCurrentStoryboard(out var storyboard);
            return new Storyboard(storyboard);
        }

        public void SetLowerBound(double bound)
        {
            _variable.SetLowerBound(bound);
        }

        public void SetLowerBoundVector(double[] bound)
        {
            _variable.SetLowerBoundVector(bound);
        }

        public void SetUpperBound(double bound)
        {
            _variable.SetUpperBound(bound);
        }

        public void SetUpperBoundVector(double[] bound)
        {
            _variable.SetUpperBoundVector(bound);
        }

        public void SetRoundingMode(int mode)
        {
            _variable.SetRoundingMode((UI_ANIMATION_ROUNDING_MODE)mode);
        }
    }
}