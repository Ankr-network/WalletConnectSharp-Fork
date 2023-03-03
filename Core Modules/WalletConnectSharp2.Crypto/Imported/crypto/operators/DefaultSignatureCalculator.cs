﻿using System;
using System.IO;

using Org.WalletConnect2.Crypto.IO;

namespace Org.WalletConnect2.Crypto.Operators
{
    public class DefaultSignatureCalculator
        : IStreamCalculator<IBlockResult>
    {
        private readonly SignerSink mSignerSink;

        public DefaultSignatureCalculator(ISigner signer)
        {
            this.mSignerSink = new SignerSink(signer);
        }

        public Stream Stream
        {
            get { return mSignerSink; }
        }

        public IBlockResult GetResult()
        {
            return new DefaultSignatureResult(mSignerSink.Signer);
        }
    }
}
