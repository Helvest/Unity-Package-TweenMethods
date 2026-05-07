using UnityEngine;

namespace SimpleTweening
{
internal class Circ : Easing
{
	public override float EaseIn(float t)
	{
		if (t > 1f || t < -1f)
		{
			return t;
		}

		return 1f - Mathf.Sqrt(1f - t * t);
	}

	public override float EaseOut(float t)
	{
		if (t > 2f || t < -2f)
		{
			return 2f - t;
		}

		return Mathf.Sqrt(1f - (--t * t));
	}
}
}