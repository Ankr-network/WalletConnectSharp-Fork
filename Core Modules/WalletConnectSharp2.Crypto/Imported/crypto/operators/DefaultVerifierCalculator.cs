using System;
using System.IO;

using Org.WalletConnect2.Crypto.IO;

namespace Org.WalletConnect2.Crypto.Operators
{
    public class DefaultVerifierCalculator
        : IStreamCalculator<IVerifier>
    {
        private readonly SignerSink mSignerSink;

        public DefaultVerifierCalculator(ISigner signer)
        {
            this.mSignerSink = new SignerSink(signer);
        }

        public Stream Stream
        {
            get { return mSignerSink; }
        }

        public IVerifier GetResult()
        {
            return new DefaultVerifierResult(mSignerSink.Signer);
        }
    }
}
