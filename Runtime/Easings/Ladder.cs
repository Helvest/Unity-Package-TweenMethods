using UnityEngine;

namespace SimpleTweening
{
public class Ladder : EasingParam
{
	public override float EaseIn(float t, float steps)
	{
		return (int)(t * steps) / steps;
	}

	public override float EaseOut(float t, float steps)
	{
		return 1f - (int)((1f - t) * steps) / steps;
	}
}
}