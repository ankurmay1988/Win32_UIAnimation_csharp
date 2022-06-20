using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public class Storyboard: IStoryboard
    {
        internal IUIAnimationStoryboard2 _storyboard;

        internal Storyboard(IUIAnimationStoryboard2 storyboard)
        {
            this._storyboard = storyboard;
        }

        public void Abandon()
        {
            _storyboard.Abandon();
        }

        public void AddKeyframeAfterTransition(AnimationTransition transition, out int keyframe)
        {
            _storyboard.AddKeyframeAfterTransition(transition._transition, out var _keyframe);
            keyframe = (int)_keyframe.Value;
        }

        public void AddKeyframeAtOffset(int existingKeyframe, double offset, out int keyframe)
        {
            var _existingKeyframe = new UI_ANIMATION_KEYFRAME(existingKeyframe); 
            _storyboard.AddKeyframeAtOffset(_existingKeyframe, offset, out var _keyframe);
            keyframe = (int)_keyframe.Value;
        }

        public void AddTransition(AnimationVariable variable, AnimationTransition transition)
        {
            _storyboard.AddTransition(variable._variable, transition._transition);
        }

        public void AddTransitionAtKeyframe(AnimationVariable variable, AnimationTransition transition, int startKeyframe)
        {
            var _startKeyframe = new UI_ANIMATION_KEYFRAME(startKeyframe);
            _storyboard.AddTransitionAtKeyframe(variable._variable, transition._transition, _startKeyframe);
        }

        public void AddTransitionBetweenKeyframes(AnimationVariable variable, AnimationTransition transition, int startKeyframe, int endKeyframe)
        {
            var _startKeyframe = new UI_ANIMATION_KEYFRAME(startKeyframe);
            var _endKeyframe = new UI_ANIMATION_KEYFRAME(endKeyframe);
            _storyboard.AddTransitionBetweenKeyframes(variable._variable, transition._transition, _startKeyframe, _endKeyframe);
        }

        public void Conclude()
        {
            _storyboard.Conclude();
        }

        public void Finish(double completionDeadline)
        {
            _storyboard.Finish(completionDeadline);
        }

        public double GetElapsedTime()
        {
            _storyboard.GetElapsedTime(out var d);
            return d;
        }

        public int GetStatus()
        {
            _storyboard.GetStatus(out var d);
            return (int)d;
        }

        public void HoldVariable(AnimationVariable variable)
        {
            _storyboard.HoldVariable(variable._variable);
        }

        public void RepeatBetweenKeyframes(int startKeyframe, int endKeyframe, double cRepetition, int repeatMode, OnLoopIterationChanged pIterationChangeHandler, nuint id, bool fRegisterForNextAnimationEvent)
        {
            var _startKeyframe = new UI_ANIMATION_KEYFRAME(startKeyframe);
            var _endKeyframe = new UI_ANIMATION_KEYFRAME(endKeyframe);
            AnimationLoopIterationChangeHandler handler = null;
            if (pIterationChangeHandler != null)
            {
                handler = new AnimationLoopIterationChangeHandler();
                handler.Handler += pIterationChangeHandler;
            }
            _storyboard.RepeatBetweenKeyframes(_startKeyframe, _endKeyframe, cRepetition, (UI_ANIMATION_REPEAT_MODE)repeatMode, handler, id, fRegisterForNextAnimationEvent); ;
        }

        public int Schedule(double timeNow)
        {
            UI_ANIMATION_SCHEDULING_RESULT res;
            unsafe
            {
                _storyboard.Schedule(timeNow, &res);
            }

            return (int)res;
        }

        public void SetLongestAcceptableDelay(double delay)
        {
            _storyboard.SetLongestAcceptableDelay(delay);
        }

        public void SetSkipDuration(double secondsDuration)
        {
            _storyboard.SetSkipDuration(secondsDuration);
        }

        public void SetStoryboardEventHandler(OnStoryboardStatusChanged storyboardStatusChangedhandler, OnStoryboardUpdated storyboardUpdatedHandler, bool fRegisterStatusChangeForNextAnimationEvent, bool fRegisterUpdateForNextAnimationEvent)
        {
            AnimationStoryboardEventHandler handler = null;
            if (storyboardStatusChangedhandler != null || storyboardUpdatedHandler != null)
            {
                handler = new AnimationStoryboardEventHandler();
                if (storyboardStatusChangedhandler != null)
                    handler.StatusChangedHandler += storyboardStatusChangedhandler;

                if (storyboardUpdatedHandler != null)
                    handler.StoryboardUpdatedHandler += storyboardUpdatedHandler;
            }
            _storyboard.SetStoryboardEventHandler(handler, fRegisterStatusChangeForNextAnimationEvent, fRegisterUpdateForNextAnimationEvent);

        }
    }
}