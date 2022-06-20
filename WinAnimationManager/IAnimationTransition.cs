namespace WinAnimationManager
{
    public interface IAnimationTransition
    {
		/// <summary>Gets the number of dimensions in which the animation variable has a transition specified.</summary>
		/// <returns>The number of dimensions. If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransition2-getdimension">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		uint GetDimension();
		/// <summary>Sets the initial value of the transition.</summary>
		/// <param name="value">The initial value for the transition.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransition2-setinitialvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetInitialValue(double value);
		/// <summary>Sets the initial value of the transition for each specified dimension in the animation variable.</summary>
		/// <param name="value">A vector (of size <i>cDimension</i>) that contains  the initial values for the transition.</param>
		/// <returns>Returns <b>S_OK</b> if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransition2-setinitialvectorvalue">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetInitialVectorValue(double[] value);
		/// <summary>Sets the initial velocity of the transition.</summary>
		/// <param name="velocity">The initial velocity for the transition.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransition2-setinitialvelocity">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetInitialVelocity(double velocity);
		/// <summary>Sets the initial velocity of the transition for each specified dimension in the animation variable.</summary>
		/// <param name="velocity">A vector (of size <i>cDimension</i>) that contains  the initial velocities for the transition.</param>
		/// <returns>Returns S_OK if successful; otherwise an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransition2-setinitialvectorvelocity">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void SetInitialVectorVelocity(double[] velocity);
		/// <summary>Determines whether the duration of a transition is known.</summary>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransition2-isdurationknown">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		void IsDurationKnown();
		/// <summary>Gets the duration of the transition.</summary>
		/// <param name="duration">The duration of the transition, in seconds.</param>
		/// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an  <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationtransition2-getduration">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		double GetDuration();
	}
}