using UnityEngine;

namespace SimpleTweening
{
internal class Elastic : Easing
{
	private const float p = 20.9439510239f;
	private const float s = 0.075f;

	public override float EaseIn(float t)
	{
		if (t == 0f || t == 1f)
		{
			return t;
		}

		return Mathf.Pow(2f, 10f * (t -= 1f)) * -Mathf.Sin((t - s) * p);
	}

	public override float EaseOut(float t)
	{
		if (t == 0f || t == 1f)
		{
			return t;
		}

		return Mathf.Pow(2f, -10f * t) * Mathf.Sin((t - s) * p) + 1f;
	}
}
}