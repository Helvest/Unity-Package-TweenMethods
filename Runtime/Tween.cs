using UnityEngine;

namespace SimpleTweening
{
public static class Tween
{
#region Arrays

	private static readonly IEasing[] _easings = new IEasing[]
	{
		new Step(),
		new Linear(),
		new Sine(),
		new Power(2f),
		new Power(3f),
		new Power(4f),
		new Power(5f),
		new Elastic(),
		new Bounce(),
		new Back(),
		new Expo(2f),
		new Circ(),
	};

	private static readonly IEasingParam[] _easingParams = new IEasingParam[]
	{
		new PowerParam(),
		new ExpoParam(),
		new Ladder(),
		new LadderNext(),
		new LadderClose(),
	};

#endregion

#region Ease

	public static float Ease(float t, EaseType type, TweenPart part, Option option = Option.None)
	{
		switch (part)
		{
			default:
			case TweenPart.None:
				return t;
			case TweenPart.In:
				return EaseIn(t, type, option);
			case TweenPart.Out:
				return EaseOut(t, type, option);
			case TweenPart.InOut:
				return EaseInOut(t, type, option);
			case TweenPart.OutIn:
				return EaseOutIn(t, type, option);
		}
	}

	public static float Ease(float t, float value, EaseParamType type, TweenPart part, Option option = Option.None)
	{
		switch (part)
		{
			default:
			case TweenPart.None:
				return t;
			case TweenPart.In:
				return EaseIn(t, value, type, option);
			case TweenPart.Out:
				return EaseOut(t, value, type, option);
			case TweenPart.InOut:
				return EaseInOut(t, value, type, option);
			case TweenPart.OutIn:
				return EaseOutIn(t, value, type, option);
		}
	}

#endregion

#region EaseIn

	public static float EaseIn(float t, EaseType type, Option option = Option.None)
	{
		t = _easings[(byte)type].EaseIn(t);

		switch (option)
		{
			default:
			case Option.None:
			case Option.FlipOut:
				return t;
			case Option.FlipIn:
			case Option.FlipAll:
				return 1 - t;
		}
	}

	public static float EaseIn(float t, float value, EaseParamType type, Option option = Option.None)
	{
		t = _easingParams[(byte)type].EaseIn(t, value);

		switch (option)
		{
			default:
			case Option.None:
			case Option.FlipOut:
				return t;
			case Option.FlipIn:
			case Option.FlipAll:
				return 1 - t;
		}
	}

#endregion

#region EaseOut

	public static float EaseOut(float t, EaseType type, Option option = Option.None)
	{
		t = _easings[(byte)type].EaseOut(t);

		switch (option)
		{
			default:
			case Option.None:
			case Option.FlipIn:
				return t;
			case Option.FlipOut:
			case Option.FlipAll:
				return 1 - t;
		}
	}

	public static float EaseOut(float t, float value, EaseParamType type, Option option = Option.None)
	{
		t = _easingParams[(byte)type].EaseOut(t, value);

		switch (option)
		{
			default:
			case Option.None:
			case Option.FlipIn:
				return t;
			case Option.FlipOut:
			case Option.FlipAll:
				return 1 - t;
		}
	}

#endregion

#region EaseInOut

	public static float EaseInOut(float t, EaseType typeIn, EaseType typeOut)
	{
		return t < 0.5f ? EaseInOut(t, typeIn) : EaseInOut(t, typeOut);
	}

	public static float EaseInOut(float t, EaseType type, Option option = Option.None)
	{
		float r = _easings[(byte)type].EaseInOut(t);

		switch (option)
		{
			default:
			case Option.None:
				return r;

			case Option.FlipIn:

				if (t <= 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipOut:

				if (t > 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipAll:
				return 1 - r;
		}
	}

	public static float EaseInOut(float t, float valueIn, float valueOut, EaseParamType typeIn, EaseParamType typeOut)
	{
		return t < 0.5f ? EaseInOut(t, valueIn, typeIn) : EaseInOut(t, valueOut, typeOut);
	}

	public static float EaseInOut(float t, float value, EaseParamType type, Option option = Option.None)
	{
		float r = _easingParams[(byte)type].EaseInOut(t, value);

		switch (option)
		{
			default:
			case Option.None:
				return r;

			case Option.FlipIn:

				if (t <= 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipOut:

				if (t > 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipAll:
				return 1 - r;
		}
	}

#endregion

#region EaseOutIn

	public static float EaseOutIn(float t, EaseType typeIn, EaseType typeOut, Option option = Option.None)
	{
		return t < 0.5f ? EaseOutIn(t, typeIn, option) : EaseOutIn(t, typeOut, option);
	}

	public static float EaseOutIn(float t, EaseType type, Option option = Option.None)
	{
		float r = _easings[(byte)type].EaseOutIn(t);

		switch (option)
		{
			default:
			case Option.None:
				return r;

			case Option.FlipIn:

				if (t <= 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipOut:

				if (t > 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipAll:
				return 1 - r;
		}
	}

	public static float EaseOutIn(float t, float valueIn, float valueOut, EaseParamType typeIn, EaseParamType typeOut,
		Option option = Option.None)
	{
		return t < 0.5f ? EaseOutIn(t, valueIn, typeIn, option) : EaseOutIn(t, valueOut, typeOut, option);
	}

	public static float EaseOutIn(float t, float value, EaseParamType type, Option option = Option.None)
	{
		float r = _easingParams[(byte)type].EaseOutIn(t, value);

		switch (option)
		{
			default:
			case Option.None:
				return r;

			case Option.FlipIn:

				if (t <= 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipOut:

				if (t > 0.5f)
				{
					return 1 - r;
				}

				return r;

			case Option.FlipAll:
				return 1 - r;
		}
	}

#endregion

#region Mix

	public static float Mix(float t, float blend, EaseType typeA, EaseType typeB, TweenPart part,
		Option option = Option.None)
	{
		return (1 - blend) * Ease(t, typeA, part, option) + blend * Ease(t, typeB, part, option);
	}

	public static float Mix(float t, float blend, EaseType typeA, EaseType typeB, TweenPart partA, TweenPart partB,
		Option optionA = Option.None, Option optionB = Option.None)
	{
		return (1 - blend) * Ease(t, typeA, partA, optionA) + blend * Ease(t, typeB, partB, optionB);
	}

	public static float Mix(float t, float blend, float valueA, float valueB, EaseParamType typeA, EaseParamType typeB,
		TweenPart part, Option option = Option.None)
	{
		return (1 - blend) * Ease(t, valueA, typeA, part, option) + blend * Ease(t, valueB, typeB, part, option);
	}

	public static float Mix(float t, float blend, float valueA, float valueB, EaseParamType typeA, EaseParamType typeB,
		TweenPart partA, TweenPart partB, Option optionA = Option.None, Option optionB = Option.None)
	{
		return (1 - blend) * Ease(t, valueA, typeA, partA, optionA) + blend * Ease(t, valueB, typeB, partB, optionB);
	}

#endregion

#region Intepolations methods

	public static float Ease(float a, float b, float t, EaseType type, TweenPart part)
	{
		return a + (b - a) * Ease(t, type, part);
	}

	public static float Ease(float a, float b, float t, float value, EaseParamType type, TweenPart part)
	{
		return a + (b - a) * Ease(t, value, type, part);
	}

	public static Vector2 Ease(Vector2 a, Vector2 b, float t, TweenPart part = TweenPart.In,
		EaseType type = EaseType.Sine)
	{
		t = Ease(t, type, part);

		return new(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
	}

	public static Vector2 Ease(Vector2 a, Vector2 b, float t, float value, EaseParamType type, TweenPart part)
	{
		t = Ease(t, value, type, part);

		return new(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
	}

	public static Vector3 Ease(Vector3 a, Vector3 b, float t, TweenPart part = TweenPart.In,
		EaseType type = EaseType.Sine)
	{
		t = Ease(t, type, part);

		return new(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
	}

	public static Vector3 Ease(Vector3 a, Vector3 b, float t, float value, EaseParamType type, TweenPart part)
	{
		t = Ease(t, value, type, part);

		return new(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
	}

	public static Vector4 Ease(Vector4 a, Vector4 b, float t, TweenPart part = TweenPart.In,
		EaseType type = EaseType.Sine)
	{
		t = Ease(t, type, part);

		return new(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
	}

	public static Vector4 Ease(Vector4 a, Vector4 b, float t, float value, EaseParamType type, TweenPart part)
	{
		t = Ease(t, value, type, part);

		return new(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
	}

	public static Quaternion Ease(Quaternion a, Quaternion b, float t, TweenPart part = TweenPart.In,
		EaseType type = EaseType.Sine)
	{
		return Quaternion.LerpUnclamped(a, b, Ease(t, type, part));
	}

	public static Quaternion Ease(Quaternion a, Quaternion b, float t, float value, EaseParamType type, TweenPart part)
	{
		return Quaternion.LerpUnclamped(a, b, Ease(t, value, type, part));
	}

	public static Color32 Ease(Color32 a, Color32 b, float t, TweenPart part = TweenPart.In,
		EaseType type = EaseType.Sine)
	{
		return Color32.LerpUnclamped(a, b, Ease(t, type, part));
	}

	public static Color32 Ease(Color32 a, Color32 b, float t, float value, EaseParamType type, TweenPart part)
	{
		return Color32.LerpUnclamped(a, b, Ease(t, value, type, part));
	}

	public static Color Ease(Color a, Color b, float t, TweenPart part = TweenPart.In, EaseType type = EaseType.Sine)
	{
		t = Ease(t, type, part);

		return new(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
	}

	public static Color Ease(Color a, Color b, float t, float value, EaseParamType type, TweenPart part)
	{
		t = Ease(t, value, type, part);

		return new(a.r + (b.r - a.r) * t, a.g + (b.g - a.g) * t, a.b + (b.b - a.b) * t, a.a + (b.a - a.a) * t);
	}

#endregion
}
}