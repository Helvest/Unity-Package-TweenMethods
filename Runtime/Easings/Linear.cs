using UnityEngine;

namespace SimpleTweening
{
internal class Linear : Easing
{
	public override float EaseIn(float t)
	{
		return t;
	}

	public override float EaseOut(float t)
	{
		return t;
	}

	public override float EaseInOut(float t)
	{
		return t;
	}

	public override float EaseOutIn(float t)
	{
		return t;
	}
}
}