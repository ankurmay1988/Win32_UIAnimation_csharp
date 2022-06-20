﻿namespace WinAnimationManager
{
    public interface ITransitionLibrary
    {
		/// <summary>Creates an instantaneous scalar transition.</summary>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <param name="transition">The new instantaneous transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createinstantaneoustransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateInstantaneousTransition(double finalValue);
		/// <summary>Creates an instantaneous vector transition for each specified dimension.</summary>
		/// <param name="finalValue">A vector (of size <i>cDimension</i>) that contains  the values of the animation variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createinstantaneousvectortransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateInstantaneousVectorTransition(double[] finalValue);
		/// <summary>Creates a constant scalar transition.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createconstanttransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateConstantTransition(double duration);
		/// <summary>Creates a discrete scalar transition.</summary>
		/// <param name="delay">The amount of time by which to delay the instantaneous switch to the final value.</param>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <param name="hold">The amount of time by which to hold the variable at its final value.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-creatediscretetransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateDiscreteTransition(double delay, double finalValue, double hold);
		/// <summary>Creates a discrete vector transition for each specified dimension.</summary>
		/// <param name="delay">The amount of time by which to delay the instantaneous switch to the final value.</param>
		/// <param name="finalValue">A vector (of size <i>cDimension</i>) that contains  the final values of the animation variable at the end of the transition.</param>
		/// <param name="hold">The amount of time by which to hold the variable at its final value.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-creatediscretevectortransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateDiscreteVectorTransition(double delay, double[] finalValue, double hold);
		/// <summary>Creates a linear scalar transition.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createlineartransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateLinearTransition(double duration, double finalValue);
		/// <summary>Creates a linear vector transition in the specified dimension.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="finalValue">A vector (of size <i>cDimension</i>) that contains  the final values of the animation variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createlinearvectortransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateLinearVectorTransition(double duration, double[] finalValue);
		/// <summary>Creates a linear-speed scalar transition.</summary>
		/// <param name="speed">The absolute value of the velocity in units/second.</param>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createlineartransitionfromspeed">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateLinearTransitionFromSpeed(double speed, double finalValue);
		/// <summary>Creates a linear-speed vector transition in the specified dimension.</summary>
		/// <param name="speed">The absolute value of the velocity in units/second.</param>
		/// <param name="finalValue">A vector (of size <i>cDimension</i>) that contains  the final values of the animation variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createlinearvectortransitionfromspeed">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateLinearVectorTransitionFromSpeed(double speed, double[] finalValue);
		/// <summary>Creates a sinusoidal scalar transition where amplitude is determined by initial velocity.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="period">The period of oscillation of the sinusoidal wave.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createsinusoidaltransitionfromvelocity">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateSinusoidalTransitionFromVelocity(double duration, double period);
		/// <summary>Creates a sinusoidal-range scalar transition with a specified range of oscillation.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="minimumValue">The value of the animation variable at a trough of the sinusoidal wave.</param>
		/// <param name="maximumValue">The value of the animation variable at a peak of the sinusoidal wave.</param>
		/// <param name="period">The period of oscillation of the sinusoidal wave.</param>
		/// <param name="slope">The slope at the start of the transition. see <i>UI_ANIMATION_SLOPE</i></param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createsinusoidaltransitionfromrange">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateSinusoidalTransitionFromRange(double duration, double minimumValue, double maximumValue, double period, int slope);
		/// <summary>Creates an accelerate-decelerate scalar transition.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <param name="accelerationRatio">The ratio of <i>duration</i> time spent accelerating (0 to 1).</param>
		/// <param name="decelerationRatio">The ratio of <i>duration</i> time spent decelerating (0 to 1).</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createacceleratedeceleratetransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateAccelerateDecelerateTransition(double duration, double finalValue, double accelerationRatio, double decelerationRatio);
		/// <summary>Creates a reversal scalar transition.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createreversaltransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateReversalTransition(double duration);
		/// <summary>Creates a cubic scalar transition.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <param name="finalVelocity">The velocity of the variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createcubictransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateCubicTransition(double duration, double finalValue, double finalVelocity);
		/// <summary>Creates a cubic vector transition for each specified dimension.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="finalValue">A vector (of size <i>cDimension</i>) that contains  the final values of the animation variable at the end of the transition.</param>
		/// <param name="finalVelocity">A vector (of size <i>cDimension</i>) that contains  the final velocities (in units per second) of the animation variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createcubicvectortransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateCubicVectorTransition(double duration, double[] finalValue, double[] finalVelocity);
		/// <summary>Creates a smooth-stop scalar transition.</summary>
		/// <param name="maximumDuration">The maximum duration of the transition.</param>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createsmoothstoptransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateSmoothStopTransition(double maximumDuration, double finalValue);
		/// <summary>Creates a parabolic-acceleration scalar transition.</summary>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <param name="finalVelocity">The velocity, in units/second, at the end of the transition.</param>
		/// <param name="acceleration">The acceleration, in units/second², during the transition.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createparabolictransitionfromacceleration">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateParabolicTransitionFromAcceleration(double finalValue, double finalVelocity, double acceleration);
		/// <summary>Creates a cubic Bézier linear scalar transition.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="finalValue">The value of the animation variable at the end of the transition.</param>
		/// <param name="x1">The x-coordinate of the first control point.</param>
		/// <param name="y1">The y-coordinate of the first control point.</param>
		/// <param name="x2">The x-coordinate of the second control point.</param>
		/// <param name="y2">The y-coordinate of the second control point.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createcubicbezierlineartransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateCubicBezierLinearTransition(double duration, double finalValue, double x1, double y1, double x2, double y2);
		/// <summary>Creates a cubic Bézier linear vector transition for each specified dimension.</summary>
		/// <param name="duration">The duration of the transition.</param>
		/// <param name="finalValue">A vector (of size <i>cDimension</i>) that contains  the final values of the animation variable at the end of the transition.</param>
		/// <param name="x1">The x-coordinate of the first control point.</param>
		/// <param name="y1">The y-coordinate of the first control point.</param>
		/// <param name="x2">The x-coordinate of the second control point.</param>
		/// <param name="y2">The y-coordinate of the second control point.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransitionlibrary2-createcubicbezierlinearvectortransition">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		AnimationTransition CreateCubicBezierLinearVectorTransition(double duration, double[] finalValue, double x1, double y1, double x2, double y2);
	}
}