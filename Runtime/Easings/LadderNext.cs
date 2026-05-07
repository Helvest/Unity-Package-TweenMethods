using UnityEngine;

namespace SimpleTweening
{
public class LadderNext : EasingParam
{
	public override float EaseIn(float t, float steps)
	{
		float pow = Mathf.Pow(2f, steps);

		return Mathf.NextPowerOfTwo((int)(t * pow)) / pow;
	}

	public override float EaseOut(float t, float steps)
	{
		float pow = Mathf.Pow(2f, steps);

		return 1f - Mathf.NextPowerOfTwo((int)((1f - t) * pow)) / pow;
	}
}
}