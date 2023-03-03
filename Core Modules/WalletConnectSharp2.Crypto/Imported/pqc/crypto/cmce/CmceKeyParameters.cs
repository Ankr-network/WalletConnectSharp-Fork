using Org.WalletConnect2.Crypto;

namespace Org.BouncyCastle.Pqc.Crypto.Cmce
{
    public abstract class CmceKeyParameters
        : AsymmetricKeyParameter
    {
        private readonly CmceParameters parameters;

        internal CmceKeyParameters(bool isPrivate, CmceParameters parameters)
            : base(isPrivate)
        {
            this.parameters = parameters;
        }

        public CmceParameters Parameters => parameters;
    }
}
