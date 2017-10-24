using System;
using Xamarin.Forms;

namespace ProfileLayout.Converters
{
	public class StringToColorConverter:IValueConverter
	{
		public StringToColorConverter()
		{
		}

		#region IValueConverter implementation

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			var colorString = value.ToString();
			switch(colorString)
			{
				case "": 
					return Color.Default;
				case "Accent":
					return Color.Accent;
				default:
					return Color.FromHex(colorString);
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value.ToString() == "Yes";
		}

		#endregion
	}
}
