namespace WalletConnectSharp.Common.Logging;

public interface IWC2Logger
{
	void Log(string text);
	void LogWarning(string text);
	void LogError(string text);
}
