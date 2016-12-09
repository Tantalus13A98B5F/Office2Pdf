using System;

namespace Office2Pdf
{
	/// <summary>
	/// Description of IConverter.
	/// </summary>
	public interface IConverter
	{
		bool Convert2Pdf(string src, string dst);
	}
}
