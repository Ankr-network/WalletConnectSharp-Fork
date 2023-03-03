namespace Org.WalletConnect2.Crypto
{
    public interface IMacDerivationFunction
        : IDerivationFunction
    {
        IMac Mac { get; }
    }
}
