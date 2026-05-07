using UnityEngine;

namespace SimpleTweening
{
internal class Sine : Easing
{
	public const float PI = 3.1415926535897931f;
	public const float HalfPI = 1.57079632679f;

	public override float EaseIn(float t)
	{
		return Mathf.Sin(t * HalfPI - HalfPI) + 1f;
	}

	public override float EaseOut(float t)
	{
		return Mathf.Sin(t * HalfPI);
	}

	public override float EaseInOut(float t)
	{
		return (Mathf.Sin(t * PI - HalfPI) + 1f) / 2f;
	}
}
}