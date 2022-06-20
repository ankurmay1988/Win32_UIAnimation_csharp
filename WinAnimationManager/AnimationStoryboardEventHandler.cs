using System;
using System.Collections.Generic;
using System.Text;
using Windows.Win32;
using Windows.Win32.UI.Animation;

namespace WinAnimationManager
{
	/// <summary>
	/// 
	/// </summary>
	/// <param name="storyboard">Storyboard</param>
	/// <param name="newStatus">Gets the status of the storyboard.
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
	/// </param>
	/// <param name="previousStatus">Previous storyboard state in int. For all values See <i>newStatus</i> parameter help</param>
	public delegate void OnStoryboardStatusChanged(Storyboard storyboard, int newStatus, int previousStatus);
	public delegate void OnStoryboardUpdated(Storyboard storyboard);
    internal class AnimationStoryboardEventHandler: IUIAnimationStoryboardEventHandler2
    {
		internal OnStoryboardStatusChanged StatusChangedHandler;
		internal OnStoryboardUpdated StoryboardUpdatedHandler;
		public void OnStoryboardStatusChanged(IUIAnimationStoryboard2 storyboard, UI_ANIMATION_STORYBOARD_STATUS newStatus, UI_ANIMATION_STORYBOARD_STATUS previousStatus)
        {
			this.StatusChangedHandler?.Invoke(new Storyboard(storyboard), (int)newStatus, (int)previousStatus);
        }

        public void OnStoryboardUpdated(IUIAnimationStoryboard2 storyboard)
        {
			this.StoryboardUpdatedHandler?.Invoke(new Storyboard(storyboard));
        }
    }
}
