﻿using System.Collections;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace vr4content
{
	[TrackClipType(typeof(IntVariableAsset))]
	[TrackBindingType(typeof(IntVariable))]
	public class IntVariableTrack : TrackAsset {}
}