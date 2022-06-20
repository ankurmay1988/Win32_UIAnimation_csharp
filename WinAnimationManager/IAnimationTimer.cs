using Windows.Win32;
using Windows.Win32.UI.Animation;


namespace WinAnimationManager
{
    public interface IAnimationTimer
    {
		///// <summary>Specifies a timer update handler.</summary>
		///// <param name="updateHandler">
		///// <para>A timer update handler, or <b>NULL</b> (see Remarks).  The specified object must implement the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nn-uianimation-iuianimationtimerupdatehandler">IUIAnimationTimerUpdateHandler</a> interface.</para>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-settimerupdatehandler#parameters">Read more on docs.microsoft.com</see>.</para>
		///// </param>
		///// <param name="idleBehavior">
		///// <para>A member of <a href="https://docs.microsoft.com/windows/win32/api/uianimation/ne-uianimation-ui_animation_idle_behavior">UI_ANIMATION_IDLE_BEHAVIOR</a> that specifies the behavior of the timer when it is idle.</para>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-settimerupdatehandler#parameters">Read more on docs.microsoft.com</see>.</para>
		///// </param>
		///// <returns>If the method succeeds, it returns S_OK. If the update handler is already connected to a timer, this method returns <b>UI_E_TIMER_CLIENT_ALREADY_CONNECTED</b>. Otherwise, it returns an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-settimerupdatehandler">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void SetTimerUpdateHandler(winmdroot.UI.Animation.IUIAnimationTimerUpdateHandler updateHandler, winmdroot.UI.Animation.UI_ANIMATION_IDLE_BEHAVIOR idleBehavior);
		
		///// <summary>Specifies a timer event handler.</summary>
		///// <param name="handler">
		///// <para>A timer event handler.  The specified object must implement the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nn-uianimation-iuianimationtimereventhandler">IUIAnimationTimerEventHandler</a> interface or be <b>NULL</b>. See Remarks.</para>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-settimereventhandler#parameters">Read more on docs.microsoft.com</see>.</para>
		///// </param>
		///// <returns>If the method succeeds, it returns S_OK. Otherwise, it returns an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-settimereventhandler">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void SetTimerEventHandler(winmdroot.UI.Animation.IUIAnimationTimerEventHandler handler);

		/// <summary>Enables the animation timer.</summary>
		/// <returns>If the method succeeds, it returns S_OK. Otherwise, it returns an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-enable">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void Enable();
		/// <summary>Disables the animation timer.</summary>
		/// <returns>If the method succeeds, it returns S_OK. Otherwise, it returns an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-disable">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void Disable();
		/// <summary>Determines whether the timer is currently enabled.</summary>
		/// <returns>Returns S_OK if the animation timer is enabled, S_FALSE if the animation timer is disabled, or an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-isenabled">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void IsEnabled();
		/// <summary>Gets the current time.</summary>
		/// <param name="seconds">The current time, in <a href="https://docs.microsoft.com/windows/desktop/UIAnimation/ui-animation-seconds">UI_ANIMATION_SECONDS</a>.</param>
		/// <returns>If the method succeeds, it returns S_OK. Otherwise, it returns an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-gettime">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void GetTime(out double seconds);
		/// <summary>Sets the frame rate below which the timer notifies the application that rendering is too slow.</summary>
		/// <param name="framesPerSecond">The minimum desirable frame rate, in frames per second.</param>
		/// <returns>If the method succeeds, it returns S_OK. Otherwise, it returns an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtimer-setframeratethreshold">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetFrameRateThreshold(uint framesPerSecond);
	}
}