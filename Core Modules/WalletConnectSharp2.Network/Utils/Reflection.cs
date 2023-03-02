using System.Reflection;

namespace WalletConnectSharp.Network;

public static class Reflection
{
	private static IEnumerable<T> GetPairEnumerable<T>(T firstValue, T secondValue)
	{
		yield return firstValue;
		yield return secondValue;
	}
	
	public static FieldInfo GetPrivateFieldInfo(this Type objType, string possibleFieldName)
	{
		FieldInfo resultField = null;
		foreach (var fieldName in GetPairEnumerable(possibleFieldName, "_" + possibleFieldName))
		{
			resultField = objType.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);

			if (resultField != null)
			{
				break;
			}
		}

		return resultField;
	}
}
