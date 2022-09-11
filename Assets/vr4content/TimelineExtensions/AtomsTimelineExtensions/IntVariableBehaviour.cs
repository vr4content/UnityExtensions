using System.Collections;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace vr4content
{
    public class IntVariableBehaviour : PlayableBehaviour
    {
        public int value = 0;
        public bool repeat = false;
        private bool triggered = false;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            IntVariable trackIntVariable = playerData as IntVariable;
            if (trackIntVariable == null) return;
            if (repeat == false && triggered == true) return;

            trackIntVariable.SetValue(value);
            triggered = true;

        }
        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            triggered = false;
        }
    }
}