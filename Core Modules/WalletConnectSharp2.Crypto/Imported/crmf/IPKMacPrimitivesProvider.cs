using System;

using Org.BouncyCastle.Asn1.X509;
using Org.WalletConnect2.Crypto;

namespace Org.BouncyCastle.Crmf
{
    public interface IPKMacPrimitivesProvider   
    {
	    IDigest CreateDigest(AlgorithmIdentifier digestAlg);

        IMac CreateMac(AlgorithmIdentifier macAlg);
    }
}
