using UnityEngine;

namespace SimpleTweening
{
internal class Step : Easing
{
	public override float EaseIn(float t)
	{
		return Mathf.Round(t);
	}

	public override float EaseOut(float t)
	{
		return 1f - Mathf.Round(1f - t);
	}
}
}