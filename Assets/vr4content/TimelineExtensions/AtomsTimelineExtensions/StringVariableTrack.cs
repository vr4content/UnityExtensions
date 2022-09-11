using System.Collections;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace vr4content
{
	[TrackClipType(typeof(StringVariableAsset))]
	[TrackBindingType(typeof(StringVariable))]
	public class StringVariableTrack : TrackAsset {}
}