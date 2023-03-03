using System;

using Org.WalletConnect2.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.WalletConnect2.Crypto.Generators
{
    public class X25519KeyPairGenerator
        : IAsymmetricCipherKeyPairGenerator
    {
        private SecureRandom random;

        public virtual void Init(KeyGenerationParameters parameters)
        {
            this.random = parameters.Random;
        }

        public virtual AsymmetricCipherKeyPair GenerateKeyPair()
        {
            X25519PrivateKeyParameters privateKey = new X25519PrivateKeyParameters(random);
            X25519PublicKeyParameters publicKey = privateKey.GeneratePublicKey();
            return new AsymmetricCipherKeyPair(publicKey, privateKey);
        }
    }
}
