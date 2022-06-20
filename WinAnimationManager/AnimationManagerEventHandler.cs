using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
    /// <summary>Handles status changes to an animation manager.</summary>
    /// <param name="newStatus">The new status of the animation manager. <see cref="UI_ANIMATION_MANAGER_STATUS" /></param>
    /// <param name="previousStatus">The previous status of the animation manager. <see cref="UI_ANIMATION_MANAGER_STATUS" /></param>
    /// <returns>If the method succeeds, it returns S_OK. Otherwise, it returns an <b>HRESULT</b> error code. See <a href="/windows/desktop/UIAnimation/uianimation-error-codes">Windows Animation Error Codes</a> for a list of error codes.</returns>
    /// <remarks>
    /// <para><see href="https://docs.microsoft.com/windows/win32/api//uianimation/nf-uianimation-iuianimationmanagereventhandler2-onmanagerstatuschanged">Learn more about this API from docs.microsoft.com</see>.</para>
    /// </remarks>
    public delegate void OnManagerStatusChanged(int newStatus, int previousStatus);

    internal class AnimationManagerEventHandler : IUIAnimationManagerEventHandler2
    {
        internal event OnManagerStatusChanged onManagerStatusChanged;

        public void OnManagerStatusChanged(UI_ANIMATION_MANAGER_STATUS newStatus, UI_ANIMATION_MANAGER_STATUS previousStatus)
        {
            onManagerStatusChanged?.Invoke((int)newStatus, (int)previousStatus);
        }
    }
}
