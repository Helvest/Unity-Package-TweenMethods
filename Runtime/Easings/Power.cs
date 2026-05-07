using UnityEngine;

namespace SimpleTweening
{
internal class Power : Easing
{
	private float _power;

	public Power(float power)
	{
		_power = power;
	}

	public override float EaseIn(float t)
	{
		return Mathf.Pow(t, _power);
	}

	public override float EaseOut(float t)
	{
		return 1f - Mathf.Pow(1f - t, _power);
	}
}

internal class PowerParam : EasingParam
{
	public override float EaseIn(float t, float power)
	{
		return Mathf.Pow(t, power);
	}

	public override float EaseOut(float t, float power)
	{
		return 1f - Mathf.Pow(1f - t, power);
	}
}
}