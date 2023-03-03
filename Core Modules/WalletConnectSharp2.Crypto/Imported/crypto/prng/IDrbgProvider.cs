using System;

using Org.WalletConnect2.Crypto.Prng.Drbg;

namespace Org.WalletConnect2.Crypto.Prng
{
    internal interface IDrbgProvider
    {
        ISP80090Drbg Get(IEntropySource entropySource);
    }
}
