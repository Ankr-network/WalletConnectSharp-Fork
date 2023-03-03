﻿using System;

using Org.BouncyCastle.Security;

namespace Org.WalletConnect2.Crypto.Parameters
{
    public class Ed448KeyGenerationParameters
        : KeyGenerationParameters
    {
        public Ed448KeyGenerationParameters(SecureRandom random)
            : base(random, 448)
        {
        }
    }
}
