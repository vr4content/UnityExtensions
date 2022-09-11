using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace vr4content
{
	public class StringEventAsset : PlayableAsset, ITimelineClipAsset
	{

		public string value = "";
		public bool repeat = false;

		public ClipCaps clipCaps
		{
			get { return ClipCaps.None; }
		}

		public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
		{
			var playable = ScriptPlayable<StringEventBehaviour>.Create(graph);
			var behaviour = playable.GetBehaviour();
			behaviour.value = value;
			behaviour.repeat = repeat;
			return playable;   
		}
	}
}