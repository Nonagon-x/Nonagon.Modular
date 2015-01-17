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
		private const String DEFAULT_CULTURE = "en-US";

		/// <summary>
		/// Gets the en-US localized string or first string in sequence if available.
		/// </summary>
		/// <value>The default localized string.</value>
		public String Default
		{
			get
			{
				if(base.ContainsKey(DEFAULT_CULTURE))
					return base[DEFAULT_CULTURE];

				if(base.Count > 0)
					return base.Values.FirstOrDefault();

				return null;
			}
		}

		public static implicit operator LocalizedString(String value)
		{
			var ls = new LocalizedString();
			ls[DEFAULT_CULTURE] = value;

			return ls;
		}
	}
}

