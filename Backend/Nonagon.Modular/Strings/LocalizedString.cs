using System;
using System.Linq;
using System.Collections.Generic;

namespace Nonagon.Modular.Strings
{
	/// <summary>
	/// Localized string.
	/// </summary>
	public class LocalizedString : Dictionary<String, String>
	{
		/// <summary>
		/// Gets the en-US localized string or first string in sequence if available.
		/// </summary>
		/// <value>The default localized string.</value>
		public String Default
		{
			get
			{
				if(base.ContainsKey("en-US"))
					return base["en-US"];

				if(base.Count > 0)
					return base.Values.FirstOrDefault();

				return null;
			}
		}
	}
}

