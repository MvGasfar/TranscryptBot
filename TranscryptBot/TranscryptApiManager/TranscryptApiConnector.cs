using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranscryptApiSoapLayer;

namespace TranscryptApiManager
{
    public class TranscryptApiConnector
    {
		private readonly ExtendedTranscryptServiceMethods _extendedTranscryptApi
			= new ExtendedTranscryptServiceMethods("TranscryptServiceApiBinding", "TranscryptServiceApi");
		public ExtendedTranscryptServiceMethods ExtendedTranscryptApi { get { return _extendedTranscryptApi; } }
	}
}
