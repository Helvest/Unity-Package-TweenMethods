using UnityEngine;

namespace SimpleTweening
{
public class Expo : IEasing
{
	private float _expo;

	public Expo(float expo)
	{
		_expo = expo;
	}

	public float EaseIn(float t)
	{
		return Mathf.Pow(_expo, 10f * (t - 1f));
	}

	public float EaseOut(float t)
	{
		return 1f - Mathf.Pow(_expo, -10f * t);
	}

	public float EaseInOut(float t)
	{
		if ((t *= 2f) <= 1f)
		{
			return Mathf.Pow(_expo, 10f * (t - 1f)) / 2f;
		}

		return (1 - Mathf.Pow(_expo, -10f * (t - 1f))) / 2f + 0.5f;
	}

	public float EaseOutIn(float t)
	{
		if ((t *= 2f) <= 1f)
		{
			return (1f - Mathf.Pow(_expo, -10f * t)) / 2f;
		}

		return Mathf.Pow(_expo, 10f * (t - 2f)) / 2f + 0.5f;
	}
}

public class ExpoParam : IEasingParam
{
	public float EaseIn(float t, float expo)
	{
		return Mathf.Pow(expo, 10f * (t - 1f));
	}

	public float EaseOut(float t, float expo)
	{
		return 1f - Mathf.Pow(expo, -10f * t);
	}

	public float EaseInOut(float t, float expo)
	{
		if ((t *= 2f) <= 1f)
		{
			return Mathf.Pow(expo, 10f * (t - 1f)) / 2f;
		}

		return (1 - Mathf.Pow(expo, -10f * (t - 1f))) / 2f + 0.5f;
	}

	public float EaseOutIn(float t, float expo)
	{
		if ((t *= 2f) <= 1f)
		{
			return (1f - Mathf.Pow(expo, -10f * t)) / 2f;
		}

		return Mathf.Pow(expo, 10f * (t - 2f)) / 2f + 0.5f;
	}
}
}