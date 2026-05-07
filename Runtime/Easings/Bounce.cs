namespace SimpleTweening
{
internal class Bounce : Easing
{
	private const float a = 7.5625f;
	private const float b = 2.75f;

	private const float b1 = 1f / b;
	private const float b2 = 2f / b;
	private const float b15 = 1.5f / b;
	private const float b25 = 2.5f / b;
	private const float b225 = 2.25f / b;
	private const float b2625 = 2.625f / b;

	public override float EaseIn(float t)
	{
		return 1f - EaseOut(1f - t);
	}

	public override float EaseOut(float t)
	{
		if (t < b1)
		{
			return (a * t * t);
		}

		if (t < b2)
		{
			return (a * (t -= b15) * t + 0.75f);
		}

		if (t < b25)
		{
			return (a * (t -= b225) * t + 0.9375f);
		}

		return (a * (t -= b2625) * t + 0.984375f);
	}
}
}