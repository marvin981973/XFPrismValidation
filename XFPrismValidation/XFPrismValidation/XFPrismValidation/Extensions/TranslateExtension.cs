using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms.Xaml;
using XFPrismValidation.Resources;

namespace XFPrismValidation.Extensions
{
	public class TranslateExtension : IMarkupExtension
	{
		public string Text { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Text == null)
				return string.Empty;

			return AppResources.ResourceManager.GetString(Text, CultureInfo.CurrentCulture);
		}
	}
}
