﻿namespace Xamarin.Forms
{
	public class SolidColorBrush : Brush
	{
		public SolidColorBrush() { }

		public SolidColorBrush(Color color)
		{
			Color = color;
		}

		public static readonly BindableProperty ColorProperty = BindableProperty.Create(
			nameof(Color), typeof(Color), typeof(SolidColorBrush), Color.Default);

		public Color Color
		{
			get => (Color)GetValue(ColorProperty);
			set => SetValue(ColorProperty, value);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is SolidColorBrush dest))
				return false;

			return Color == dest.Color;
		}

		public override int GetHashCode()
		{
			return -1234567890 + Color.GetHashCode();
		}
	}
}