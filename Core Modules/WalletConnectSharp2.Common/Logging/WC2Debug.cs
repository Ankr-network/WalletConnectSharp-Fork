namespace WalletConnectSharp.Common.Logging;

public static class WC2Debug
{
	private static readonly List<IWC2Logger> Loggers = new List<IWC2Logger>();
	
	public static void AddLogger(IWC2Logger logger)
	{
		Loggers.Add(logger);
	}
	
	public static void Log(string text)
	{
		Loggers.ForEach(l => l.Log(text));
	}
	
	public static void LogWarning(string text)
	{
		Loggers.ForEach(l => l.LogWarning(text));
	}
	
	public static void LogError(string text)
	{
		Loggers.ForEach(l => l.LogWarning(text));
	}
}
