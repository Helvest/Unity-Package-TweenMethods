namespace SimpleTweening
{
internal interface IEasing
{
	float EaseIn(float t);

	float EaseOut(float t);

	float EaseInOut(float t);

	float EaseOutIn(float t);
}

internal abstract class Easing : IEasing
{
	public abstract float EaseIn(float t);

	public abstract float EaseOut(float t);

	public virtual float EaseInOut(float t)
	{
		if ((t *= 2f) <= 1f)
		{
			return EaseIn(t) / 2f;
		}

		return EaseOut(t - 1f) / 2f + 0.5f;
	}

	public virtual float EaseOutIn(float t)
	{
		if ((t *= 2f) <= 1f)
		{
			return EaseOut(t) / 2f;
		}

		return EaseIn(t - 1f) / 2f + 0.5f;
	}
}
}