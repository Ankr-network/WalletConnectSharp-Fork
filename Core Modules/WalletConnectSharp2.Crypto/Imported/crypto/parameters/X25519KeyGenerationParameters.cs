using System;

using Org.BouncyCastle.Security;

namespace Org.WalletConnect2.Crypto.Parameters
{
    public class X25519KeyGenerationParameters
        : KeyGenerationParameters
    {
        public X25519KeyGenerationParameters(SecureRandom random)
            : base(random, 255)
        {
        }
    }
}
