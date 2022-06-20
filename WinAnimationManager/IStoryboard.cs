namespace WinAnimationManager
{
    public interface IStoryboard
    {
		/// <summary>Adds a transition to the storyboard.</summary>
		/// <param name="variable">The animation variable for which the transition is to be added.</param>
		/// <param name="transition">The transition to be added.</param>
		/// <returns>
		/// <para>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. </para>
		/// <para>This doc was truncated.</para>
		/// </returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-addtransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void AddTransition(AnimationVariable variable, AnimationTransition transition);
		/// <summary>Adds a keyframe at the specified offset from an existing keyframe.</summary>
		/// <param name="existingKeyframe">The existing keyframe. To add a keyframe at an offset from the start of the storyboard, use the special keyframe <a href="https://docs.microsoft.com/previous-versions/windows/desktop/legacy/dd756780(v=vs.85)">UI_ANIMATION_KEYFRAME_STORYBOARD_START = -1</a>.</param>
		/// <param name="offset">The offset from the existing keyframe at which a new keyframe is to be added.</param>
		/// <param name="keyframe">The keyframe to be added.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-addkeyframeatoffset">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void AddKeyframeAtOffset(int existingKeyframe, double offset, out int keyframe);
		/// <summary>Adds a keyframe at the end of the specified transition.</summary>
		/// <param name="transition">The transition after which a keyframe is to be added.</param>
		/// <param name="keyframe">The keyframe to be added.</param>
		/// <returns>
		/// <para>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. </para>
		/// <para>This doc was truncated.</para>
		/// </returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-addkeyframeaftertransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void AddKeyframeAfterTransition(AnimationTransition transition, out int keyframe);
		/// <summary>Adds a transition that starts at the specified keyframe.</summary>
		/// <param name="variable">The animation variable for which a transition is to be added.</param>
		/// <param name="transition">The transition to be added.</param>
		/// <param name="startKeyframe">The keyframe that specifies the beginning of the new transition.</param>
		/// <returns>
		/// <para>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. </para>
		/// <para>This doc was truncated.</para>
		/// </returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-addtransitionatkeyframe">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void AddTransitionAtKeyframe(AnimationVariable variable, AnimationTransition transition, int startKeyframe);
		/// <summary>Adds a transition between two keyframes.</summary>
		/// <param name="variable">The animation variable for which the transition is to be added.</param>
		/// <param name="transition">The transition to be added.</param>
		/// <param name="startKeyframe">A keyframe that specifies the beginning of the new transition.</param>
		/// <param name="endKeyframe">A keyframe that specifies the end of the new transition. It must not be possible for <i>endKeyframe</i> to appear earlier in the storyboard than <i>startKeyframe</i>.</param>
		/// <returns>
		/// <para>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. </para>
		/// <para>This doc was truncated.</para>
		/// </returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-addtransitionbetweenkeyframes">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void AddTransitionBetweenKeyframes(AnimationVariable variable, AnimationTransition transition, int startKeyframe, int endKeyframe);
		/// <summary>Creates a loop between two keyframes.</summary>
		/// <param name="startKeyframe">The keyframe at which the loop is to begin.</param>
		/// <param name="endKeyframe">The keyframe at which the loop is to end. <i>endKeyframe</i> must not occur earlier in the storyboard than <i>startKeyframe</i>.</param>
		/// <param name="cRepetition">
		/// The number of times the loop is to be repeated; the last iteration of a loop can terminate fractionally between keyframes. A value of  zero indicates that the specified portion of a storyboard will not be played.  A value of <a href="https://docs.microsoft.com/windows/desktop/UIAnimation/ui-animation-repeat-indefinitely">UI_ANIMATION_REPEAT_INDEFINITELY</a> (-1) indicates that the loop will repeat indefinitely until the storyboard is trimmed or concluded.
		/// </param>
		/// <param name="repeatMode">
		/// <para>The pattern for the loop iteration. A value of <a href="https://docs.microsoft.com/windows/win32/api/uianimation/ne-uianimation-ui_animation_repeat_mode">UI_ANIMATION_REPEAT_MODE_ALTERNATE</a> (1) specifies that the  start of the loop must alternate between keyframes (k1-&gt;k2, k2-&gt;k1, k1-&gt;k2, and so on). A value of <a href="https://docs.microsoft.com/windows/win32/api/uianimation/ne-uianimation-ui_animation_repeat_mode">UI_ANIMATION_REPEAT_MODE_NORMAL</a> (0) specifies that the start of the  loop must begin with the first keyframe (k1-&gt;k2, k1-&gt;k2, k1-&gt;k2, and so on). <div class="alert"><b>Note</b>  If <i>repeatMode</i> has a value of <a href="https://docs.microsoft.com/windows/win32/api/uianimation/ne-uianimation-ui_animation_repeat_mode">UI_ANIMATION_REPEAT_MODE_ALTERNATE</a> (1) and <i>cRepetition</i> has a value of <a href="https://docs.microsoft.com/windows/desktop/UIAnimation/ui-animation-repeat-indefinitely">UI_ANIMATION_REPEAT_INDEFINITELY</a> (-1), the loop terminates on the end keyframe. </div> <div> </div></para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-repeatbetweenkeyframes#parameters">Read more on docs.microsoft.com</see>.</para>
		/// </param>
		/// <param name="pIterationChangeHandler">The handler for each loop iteration event. The default value is 0.</param>
		/// <param name="id">The loop ID to pass to <i>pIterationChangeHandler</i>. The default value is 0.</param>
		/// <param name="fRegisterForNextAnimationEvent">If true, specifies that <i>pIterationChangeHandler</i> will be incorporated into the estimate of the time interval until the next animation event that is returned by the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nf-uianimation-iuianimationmanager2-estimatenexteventtime">IUIAnimationManager2::EstimateNextEventTime</a> method. The default value is 0, or false.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-repeatbetweenkeyframes">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void RepeatBetweenKeyframes(int startKeyframe, int endKeyframe, double cRepetition, int repeatMode, OnLoopIterationChanged pIterationChangeHandler, nuint id, bool fRegisterForNextAnimationEvent);
		/// <summary>Directs the storyboard to hold the specified animation variable at its final value until the storyboard ends.</summary>
		/// <param name="variable">The animation variable.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-holdvariable">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void HoldVariable(AnimationVariable variable);
		/// <summary>Sets the longest acceptable delay before the scheduled storyboard begins.</summary>
		/// <param name="delay">The longest acceptable delay. This parameter can be a positive value, or <a href="https://docs.microsoft.com/windows/desktop/UIAnimation/ui-animation-seconds-eventually">UI_ANIMATION_SECONDS_EVENTUALLY</a> (-1) to indicate that any finite delay is acceptable.</param>
		/// <returns>Returns <b>S_OK</b> if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-setlongestacceptabledelay">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetLongestAcceptableDelay(double delay);
		/// <summary>Specifies an offset from the beginning of a storyboard at which to start animating.</summary>
		/// <param name="secondsDuration">The offset, or amount of time, to skip at the beginning of the storyboard.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-setskipduration">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetSkipDuration(double secondsDuration);
		/// <summary>Directs the storyboard to schedule itself for play.</summary>
		/// <param name="timeNow">The current time.</param>
		/// <returns>The result of the scheduling request.
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-schedule#parameters">Read more on docs.microsoft.com</see>.</para>
		/// </returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-schedule">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int Schedule(double timeNow);
		/// <summary>Completes the current iteration of a keyframe loop that is in progress (where the loop is set to UI_ANIMATION_REPEAT_INDEFINITELY), terminates the loop, and continues with the storyboard.</summary>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-conclude">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void Conclude();
		/// <summary>Finishes the storyboard within the specified time, compressing the storyboard if necessary.</summary>
		/// <param name="completionDeadline">The maximum amount of time that the storyboard can use to finish playing.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-finish">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void Finish(double completionDeadline);
		/// <summary>Terminates the storyboard, releases all related animation variables, and removes the storyboard from the schedule.</summary>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-abandon">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void Abandon();

		///// <summary>Sets the tag for the storyboard.</summary>
		///// <param name="id">The identifier portion of the tag.</param>
		///// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-settag">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void SetTag([MarshalAs(UnmanagedType.IUnknown)] object @object, uint id);

		///// <summary>Gets the tag for a storyboard.</summary>
		///// <param name="id">The identifier portion of the tag.</param>
		///// <returns>
		///// <para>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes. </para>
		///// <para>This doc was truncated.</para>
		///// </returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-gettag">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//unsafe void GetTag([MarshalAs(UnmanagedType.IUnknown)] out object @object, [Optional] uint* id);

		/// <summary>Gets the status of the storyboard.</summary>
		/// <returns>
		/// If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.
		/// See <i></i>
		/// <list type="bullet">
		/// <item>
		/// <summary>The storyboard has never been scheduled.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_BUILDING = 0</code></item>
		/// <item>
		/// <summary>The storyboard is scheduled to play.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_SCHEDULED = 1</code></item>
		/// <item>
		/// <summary>The storyboard was canceled.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_CANCELLED = 2</code></item>
		/// <item>
		/// <summary>The storyboard is currently playing.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_PLAYING = 3</code></item>
		/// <item>
		/// <summary>The storyboard was truncated.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_TRUNCATED = 4</code></item>
		/// <item>
		/// <summary>The storyboard has finished playing.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_FINISHED = 5</code></item>
		/// <item>
		/// <summary>The storyboard is built and ready for scheduling.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_READY = 6</code></item>
		/// <item>
		/// <summary>Scheduling the storyboard failed because a scheduling conflict occurred and the currently scheduled storyboard has higher priority.</summary>
		/// <code>UI_ANIMATION_STORYBOARD_INSUFFICIENT_PRIORITY = 7</code></item>
		/// </list>
		/// </returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-getstatus">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int GetStatus();
		/// <summary>Gets the time that has elapsed since the storyboard started playing.</summary>
		/// <returns>
		/// <para>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes. </para>
		/// <para>This doc was truncated.</para>
		/// </returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-getelapsedtime">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double GetElapsedTime();
		/// <summary>Specifies a handler for storyboard events.</summary>
		/// <param name="storyboardStatusChangedhandler">
		/// <para>The handler that Windows Animation should call whenever storyboard status and update events occur. The specified object must implement the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nn-uianimation-iuianimationstoryboardeventhandler2">IUIAnimationStoryboardEventHandler2</a> interface or be <b>NULL</b>. See Remarks for more info.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-setstoryboardeventhandler#parameters">Read more on docs.microsoft.com</see>.</para>
		/// </param>
		/// <param name="storyboardUpdatedHandler">
		/// <para>The handler that Windows Animation should call whenever storyboard status and update events occur. The specified object must implement the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nn-uianimation-iuianimationstoryboardeventhandler2">IUIAnimationStoryboardEventHandler2</a> interface or be <b>NULL</b>. See Remarks for more info.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-setstoryboardeventhandler#parameters">Read more on docs.microsoft.com</see>.</para>
		/// </param>
		/// <param name="fRegisterStatusChangeForNextAnimationEvent">If <b>TRUE</b>, registers the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nf-uianimation-iuianimationstoryboardeventhandler2-onstoryboardstatuschanged">OnStoryboardStatusChanged</a> event and includes those events in <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nf-uianimation-iuianimationmanager2-estimatenexteventtime">IUIAnimationManager2::EstimateNextEventTime</a>, which estimates the time interval until the next animation event. No default value.</param>
		/// <param name="fRegisterUpdateForNextAnimationEvent">If <b>TRUE</b>, registers the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nf-uianimation-iuianimationstoryboardeventhandler2-onstoryboardupdated">OnStoryboardUpdated</a> event and includes those events in <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nf-uianimation-iuianimationmanager2-estimatenexteventtime">IUIAnimationManager2::EstimateNextEventTime</a>, which estimates the time interval until the next animation event. No default value.</param>
		/// <returns>Returns <b>S_OK</b> if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationstoryboard2-setstoryboardeventhandler">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetStoryboardEventHandler(OnStoryboardStatusChanged storyboardStatusChangedhandler, OnStoryboardUpdated storyboardUpdatedHandler, bool fRegisterStatusChangeForNextAnimationEvent, bool fRegisterUpdateForNextAnimationEvent);
	}
}