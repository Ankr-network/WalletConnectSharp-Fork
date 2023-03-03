using System;

namespace Org.WalletConnect2.Crypto.Modes.Gcm
{
	public interface IGcmExponentiator
	{
		void Init(byte[] x);
		void ExponentiateX(long pow, byte[] output);
	}
}
