namespace WinAnimationManager
{
    public interface IAnimationVariable
    {
		/// <summary>Gets the number of dimensions that the animation variable is to be animated in.</summary>
		/// <returns>The number of dimensions. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getdimension">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		uint GetDimension();
		/// <summary>Gets the value of the animation variable.</summary>
		/// <returns>The value of the animation variable. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double GetValue();
		/// <summary>Gets the value of the animation variable in the specified dimension.</summary>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getvectorvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double[] GetVectorValue();
		
		///// <summary>Gets the animation curve of the animation variable.</summary>
		///// <param name="animation">The object that generates a sequence of animation curve primitives.</param>
		///// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getcurve">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void GetCurve(winmdroot.Graphics.DirectComposition.IDCompositionAnimation animation);
		
		///// <summary>Gets the animation curve of the animation variable for the specified dimension.</summary>
		///// <param name="animation">The object that generates a sequence of animation curve primitives.</param>
		///// <param name="cDimension">The number of animation curves.</param>
		///// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getvectorcurve">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void GetVectorCurve([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] winmdroot.Graphics.DirectComposition.IDCompositionAnimation[] animation, uint cDimension);
		
		/// <summary>Gets the final value of the animation variable. This is the value after all currently scheduled animations have completed.</summary>
		/// <returns>The final value of the animation variable. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getfinalvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double GetFinalValue();
		/// <summary>Gets the final value of the animation variable for the specified dimension. This is the value after all currently scheduled animations have completed.</summary>
		/// <returns>The final value of the animation variable. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getfinalvectorvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double[] GetFinalVectorValue();
		/// <summary>Gets the previous value of the animation variable. This is the value of the animation variable before the most recent update.</summary>
		/// <returns>The previous value of the animation variable. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getpreviousvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double GetPreviousValue();
		/// <summary>Gets the previous value of the animation variable for the specified dimension. This is the value of the animation variable before the most recent update.</summary>
		/// <returns>The previous value of the animation variable. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getpreviousvectorvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double[] GetPreviousVectorValue();
		/// <summary>Gets the integer value of the animation variable.</summary>
		/// <returns>The value of the animation variable as an integer.If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getintegervalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int GetIntegerValue();
		/// <summary>Gets the integer value of the animation variable for the specified dimension.</summary>
		/// <returns>The value of the animation variable as an integer. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getintegervectorvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int[] GetIntegerVectorValue();
		/// <summary>Gets the final integer value of the animation variable. This is the value after all currently scheduled animations have completed.</summary>
		/// <returns>The final value of the animation variable as an integer. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getfinalintegervalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int GetFinalIntegerValue();
		/// <summary>Gets the final integer value of the animation variable for the specified dimension. This is the value after all currently scheduled animations have completed.</summary>
		/// <returns>The final value of the animation variable as an integer. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getfinalintegervectorvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int[] GetFinalIntegerVectorValue();
		/// <summary>Gets the previous integer value of the animation variable in the specified dimension. This is the value of the animation variable before the most recent update.</summary>
		/// <returns>The previous value of the animation variable as an integer. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getpreviousintegervalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int GetPreviousIntegerValue();
		/// <summary>Gets the previous integer value of the animation variable for the specified dimension. This is the value of the animation variable before the most recent update.</summary>
		/// <returns>The previous value of the animation variable as an integer. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getpreviousintegervectorvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		int[] GetPreviousIntegerVectorValue();
		/// <summary>Gets the active storyboard for the animation variable.</summary>
		/// <returns>The active storyboard, or NULL if the animation variable is not being animated. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-getcurrentstoryboard">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		Storyboard GetCurrentStoryboard();
		/// <summary>Sets the lower bound (floor) for the value of the animation variable. The value of the animation variable should not fall below the specified value.</summary>
		/// <param name="bound">The lower bound for the value of the animation variable.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setlowerbound">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetLowerBound(double bound);
		/// <summary>Sets the lower bound (floor) value of each specified dimension for the animation variable. The value of each animation variable should not fall below its lower bound.</summary>
		/// <param name="bound">A vector (of size <i>cDimension</i>) that contains  the lower bound values of each dimension.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setlowerboundvector">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetLowerBoundVector(double[] bound);
		/// <summary>Sets the upper bound (ceiling) for the value of the animation variable. The value of the animation variable should not rise above the specified value.</summary>
		/// <param name="bound">The upper bound for the value of the animation variable.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setupperbound">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetUpperBound(double bound);
		/// <summary>Sets the upper bound (ceiling) value of each specified dimension for the animation variable. The value of each animation variable should not rise above its upper bound.</summary>
		/// <param name="bound">A vector (of size <i>cDimension</i>) that contains  the upper bound values of each dimension.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setupperboundvector">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetUpperBoundVector(double[] bound);
		/// <summary>Sets the rounding mode of the animation variable.</summary>
		/// <param name="mode">The rounding mode. See <i>UI_ANIMATION_ROUNDING_MODE</i>
		/// <list type="bullet">
		/// <item>
		/// <summary>Round to the nearest integer.</summary>
		/// <code>UI_ANIMATION_ROUNDING_NEAREST = 0</code></item>
		/// <item><summary>Round down.</summary>
		/// <code> UI_ANIMATION_ROUNDING_FLOOR = 1</code></item>
		/// <item><summary>Round up.</summary>
		/// <code> UI_ANIMATION_ROUNDING_CEILING = 2</code></item>
		/// </list>
		/// </param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setroundingmode">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetRoundingMode(int mode);
		
		///// <summary>Sets the tag of the animation variable.</summary>
		///// <param name="id">The identifier portion of the tag.</param>
		///// <returns>Returns <b>S_OK</b> if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-settag">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void SetTag([MarshalAs(UnmanagedType.IUnknown)] object @object, uint id);
		
		///// <summary>Gets the tag of the animation variable.</summary>
		///// <param name="id">The identifier portion of the tag.</param>
		///// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-gettag">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//unsafe void GetTag([MarshalAs(UnmanagedType.IUnknown)] out object @object, [Optional] uint* id);
		
		///// <summary>Specifies a handler for changes to the value of the animation variable.</summary>
		///// <param name="handler">The handler for changes to the value of the animation variable. This parameter can be <b>NULL</b>.</param>
		///// <param name="fRegisterForNextAnimationEvent">If <b>TRUE</b>, specifies that the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nf-uianimation-iuianimationmanager2-estimatenexteventtime">EstimateNextEventTime</a> method will incorporate <i>handler</i> into its estimate of the time interval until the next animation event. No default value.</param>
		///// <returns>Returns <b>S_OK</b> if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setvariablechangehandler">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void SetVariableChangeHandler(winmdroot.UI.Animation.IUIAnimationVariableChangeHandler2 handler, winmdroot.Foundation.BOOL fRegisterForNextAnimationEvent);
		
		///// <summary>Specifies a handler for changes to the integer value of the animation variable.</summary>
		///// <param name="handler">A pointer to the handler for changes to the integer value of the animation variable. This parameter can be <b>NULL</b>.</param>
		///// <param name="fRegisterForNextAnimationEvent">If <b>TRUE</b>, specifies that the <a href="https://docs.microsoft.com/windows/desktop/api/uianimation/nf-uianimation-iuianimationmanager2-estimatenexteventtime">EstimateNextEventTime</a> method will incorporate <i>handler</i> into its estimate of the time interval until the next animation event. No default value.</param>
		///// <returns>Returns <b>S_OK</b> if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setvariableintegerchangehandler">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void SetVariableIntegerChangeHandler(winmdroot.UI.Animation.IUIAnimationVariableIntegerChangeHandler2 handler, winmdroot.Foundation.BOOL fRegisterForNextAnimationEvent);
		
		///// <summary>Specifies a handler for changes to the animation curve of the animation variable.</summary>
		///// <param name="handler">A pointer to the handler for changes to the animation curve of the animation variable. This parameter can be <b>NULL</b>.</param>
		///// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		///// <remarks>
		///// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationvariable2-setvariablecurvechangehandler">Learn more about this API from docs.microsoft.com</see>.</para>
		///// </remarks>
		//void SetVariableCurveChangeHandler(winmdroot.UI.Animation.IUIAnimationVariableCurveChangeHandler2 handler);
	}
}