namespace SimpleTweening
{
internal class Back : Easing
{
	private const float s = 1.70158f;
	private const float s2 = s + 1f;

	public override float EaseIn(float t)
	{
		return t * t * (s2 * t - s);
	}

	public override float EaseOut(float t)
	{
		return (--t) * t * (s2 * t + s) + 1f;
	}
}
}