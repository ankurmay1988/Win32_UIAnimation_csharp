using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    public class WindowsAnimationManager
    {
        private IUIAnimationManager2 _animationManager;
        private IUIAnimationTimer _animationTimer;
        private IUIAnimationTransitionLibrary2 _animationLibrary;
        private IUIAnimationManagerEventHandler2 _animationEventHandler;
        private AnimationTimerEventHandler _animationTimerEventHandler;
        private IUIAnimationTimerUpdateHandler _animationTimerUpdateEventHandler;

        public WindowsAnimationManager()
        {
            _animationManager = (IUIAnimationManager2)new UIAnimationManager2();
            _animationTimer = (IUIAnimationTimer)new UIAnimationTimer();
            _animationLibrary = (IUIAnimationTransitionLibrary2)new UIAnimationTransitionLibrary2();
        }

        public AnimationVariable CreateVariable(double initialVal)
        {
            _animationManager.CreateAnimationVariable(initialVal, out var variable);
            return new AnimationVariable(variable);
        }

        public Storyboard CreateStoryboard()
        {
            _animationManager.CreateStoryboard(out var storyboard);
            return new Storyboard(storyboard);
        }

        public TransitionLibrary TransitionLibrary { get => new TransitionLibrary(_animationLibrary); }
        public AnimationTimer AnimationTimer { get => new AnimationTimer(_animationTimer); }

        /// <summary>Handles status changes to an animation manager.</summary>
		/// <param name="onManagerStatusChanged">The new status of the animation manager.</param>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationmanagereventhandler2-onmanagerstatuschanged">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
        public void SubscribeToManagerStatusChangedEvent(OnManagerStatusChanged onManagerStatusChanged)
        {
            var handler = new AnimationManagerEventHandler();
            handler.onManagerStatusChanged += onManagerStatusChanged;
            _animationEventHandler = (IUIAnimationManagerEventHandler2)handler;
            _animationManager.SetManagerEventHandler(_animationEventHandler, false);
        }

        /// <summary>Specifies a timer event handler.</summary>
        /// <param name="onPreUpdate">
        /// <summary>Handles events that occur before an animation update begins.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimereventhandler-onpreupdate">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
        /// </param>
        /// <param name="onPostUpdate">
        /// <summary>Handles events that occur after an animation update is finished.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimereventhandler-onpostupdate">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
        /// </param>
        /// <param name="onRenderingTooSlow">
        /// <summary>Handles events that occur when the rendering frame rate for an animation falls below a minimum desirable frame rate.
		/// Parameter name <i>framesPerSecond</i> is passed the current frame rate, in frames per second.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimereventhandler-onrenderingtooslow">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
        /// </param>
        public void SetupAnimationTimer(OnPrePostUpdate onPreUpdate, OnPrePostUpdate onPostUpdate, OnRenderingTooSlow onRenderingTooSlow)
        {
            Windows.Win32.Foundation.HRESULT res;
            _animationTimerUpdateEventHandler = (IUIAnimationTimerUpdateHandler)_animationManager;
            res = _animationTimer.SetTimerUpdateHandler(_animationTimerUpdateEventHandler, UI_ANIMATION_IDLE_BEHAVIOR.UI_ANIMATION_IDLE_BEHAVIOR_CONTINUE);
            if (res.Failed) res.ThrowOnFailure(IntPtr.Zero);
            
            _animationTimerEventHandler = new AnimationTimerEventHandler();

            if (onPreUpdate != null)
                _animationTimerEventHandler.preUpdateHandler += onPreUpdate;

            if (onPostUpdate != null)
                _animationTimerEventHandler.postUpdateHandler += onPostUpdate;

            if (onRenderingTooSlow != null)
                _animationTimerEventHandler.renderingTooSlowHandler += onRenderingTooSlow;

            res = _animationTimer.SetTimerEventHandler((IUIAnimationTimerEventHandler)_animationTimerEventHandler);
            if (res.Failed) res.ThrowOnFailure(IntPtr.Zero);
        }

        public int Update(double timeNow)
        {
            UI_ANIMATION_UPDATE_RESULT r;
            unsafe
            {
                _animationManager.Update(timeNow, &r);
            }
            return (int)r;
        }

        public void PauseAllAnimations()
        {
            _animationManager.Pause();
        }

        public void ResumeAllAnimations()
        {
            _animationManager.Resume();
        }

        /// <summary>Shuts down the animation manager and all its associated objects.</summary>
        public void Shutdown()
        {
            _animationManager.Shutdown();
        }

        /// <summary>
        /// Returns true if the animation manager is idle. 
        /// </summary>
        /// <returns></returns>
        public bool IsIdle()
        {
            UI_ANIMATION_MANAGER_STATUS status;
            unsafe
            {
                _animationManager.GetStatus(&status);
            }

            return status == UI_ANIMATION_MANAGER_STATUS.UI_ANIMATION_MANAGER_IDLE;
        }

        /// <summary>
        /// Returns true if the animation manager is busy. Continue 
        /// redrawing the client area as long as there are animations scheduled
        /// </summary>
        /// <returns></returns>
        public bool IsBusy()
        {
            UI_ANIMATION_MANAGER_STATUS status;
            unsafe
            {
                _animationManager.GetStatus(&status);
            }

            return status == UI_ANIMATION_MANAGER_STATUS.UI_ANIMATION_MANAGER_BUSY;
        }

        /// <summary>Creates and schedules a single-transition storyboard.</summary>
		/// <param name="animationVariable">The animation variable.</param>
		/// <param name="animationTransition">A transition to be applied to the animation variable.</param>
		/// <param name="timeNow">The current system time.</param>
        public void ScheduleTransition(AnimationVariable animationVariable, AnimationTransition animationTransition, double timeNow)
        {
            _animationManager.ScheduleTransition(animationVariable._variable, animationTransition._transition, timeNow);
        }

        /// <summary>Creates and schedules a single-transition storyboard.</summary>
		/// <param name="animationVariable">The animation variable.</param>
		/// <param name="animationTransition">A transition to be applied to the animation variable.</param>
        public void ScheduleTransition(AnimationVariable animationVariable, AnimationTransition animationTransition)
        {
            AnimationTimer.GetTime(out var timeNow);
            _animationManager.ScheduleTransition(animationVariable._variable, animationTransition._transition, timeNow);
        }
    }
}
