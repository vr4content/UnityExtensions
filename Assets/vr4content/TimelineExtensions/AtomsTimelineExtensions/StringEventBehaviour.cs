using System.Collections;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace vr4content
{
	public class StringEventBehaviour : PlayableBehaviour
	{
		public string value = "";
		public bool repeat = false;
		private bool triggered = false;

		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
			StringEvent trackEvent = playerData as StringEvent;
			if (trackEvent == null) return;
			if (repeat == false && triggered == true) return;

				trackEvent.Raise(value);
				triggered = true;
			
		}
        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
			triggered = false;
		}
    }
}