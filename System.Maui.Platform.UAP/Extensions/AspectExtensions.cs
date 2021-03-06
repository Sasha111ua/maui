using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using global::Windows.UI.Xaml.Media;

namespace System.Maui.Platform.UWP
{
	internal static class AspectExtensions
	{
		public static Stretch ToStretch(this Aspect aspect)
		{
			switch (aspect)
			{
				case Aspect.Fill:
					return Stretch.Fill;

				case Aspect.AspectFill:
					return Stretch.UniformToFill;

				case Aspect.AspectFit:
				default:
					return Stretch.Uniform;
			}
		}
	}
}
