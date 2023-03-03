using System;

using Org.WalletConnect2.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.WalletConnect2.Crypto.Generators
{
    public class Ed448KeyPairGenerator
        : IAsymmetricCipherKeyPairGenerator
    {
        private SecureRandom random;

        public virtual void Init(KeyGenerationParameters parameters)
        {
            this.random = parameters.Random;
        }

        public virtual AsymmetricCipherKeyPair GenerateKeyPair()
        {
            Ed448PrivateKeyParameters privateKey = new Ed448PrivateKeyParameters(random);
            Ed448PublicKeyParameters publicKey = privateKey.GeneratePublicKey();
            return new AsymmetricCipherKeyPair(publicKey, privateKey);
        }
    }
}
