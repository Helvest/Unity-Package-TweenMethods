using UnityEngine;

namespace SimpleTweening
{
public class LadderClose : EasingParam
{
	public override float EaseIn(float t, float steps)
	{
		float pow = Mathf.Pow(2f, steps);

		return Mathf.ClosestPowerOfTwo((int)(t * pow)) / pow;
	}

	public override float EaseOut(float t, float steps)
	{
		float pow = Mathf.Pow(2f, steps);

		return 1f - Mathf.ClosestPowerOfTwo((int)((1f - t) * pow)) / pow;
	}
}
}