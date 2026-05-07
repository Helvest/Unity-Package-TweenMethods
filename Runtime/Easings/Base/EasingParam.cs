namespace SimpleTweening
{
public interface IEasingParam
{
	float EaseIn(float t, float p);

	float EaseOut(float t, float p);

	float EaseInOut(float t, float p);

	float EaseOutIn(float t, float p);
}

public abstract class EasingParam : IEasingParam
{
	public abstract float EaseIn(float t, float p);

	public abstract float EaseOut(float t, float p);

	public virtual float EaseInOut(float t, float p)
	{
		if ((t *= 2f) <= 1f)
		{
			return EaseIn(t, p) / 2f;
		}

		return EaseOut(t - 1f, p) / 2f + 0.5f;
	}

	public virtual float EaseOutIn(float t, float p)
	{
		if ((t *= 2f) <= 1f)
		{
			return EaseOut(t, p) / 2f;
		}

		return EaseIn(t - 1f, p) / 2f + 0.5f;
	}
}
}