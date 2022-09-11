using System.Collections;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace vr4content
{
	public class StringVariableBehaviour : PlayableBehaviour
	{
		public string value = "";
		public bool repeat = false;
		private bool triggered = false;

		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
			StringVariable trackStringVariable = playerData as StringVariable;
			if (trackStringVariable == null) return;
			if (repeat == false && triggered == true) return;

				trackStringVariable.SetValue(value);
				triggered = true;
			
		}
        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
			triggered = false;
		}
    }
}