using System.Collections;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace vr4content
{
	[TrackClipType(typeof(StringEventAsset))]
	[TrackBindingType(typeof(StringEvent))]
	public class StringEventTrack : TrackAsset {}
}