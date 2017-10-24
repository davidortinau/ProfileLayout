using System;
using Xamarin.Forms;

namespace ProfileLayout.Converters
{
	public class InvertedBoolConverter : IValueConverter
	{
		public InvertedBoolConverter()
		{
		}

		#region IValueConverter implementation

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return !(bool)value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return (bool)value;
		}

		#endregion
	}
}
