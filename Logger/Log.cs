using System;
using System.Collections.Generic;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public static class Log
{
	private static List<string> enabledTags = new List<string>();

	[Conditional("DEVELOPER_TOOLS")]
	public static void Info(string tag, string format, params object[] args)
	{
		if(!string.IsNullOrEmpty(tag) && !enabledTags.Contains(tag)) return;
		Debug.LogFormat(format, args);
	}

	[Conditional("DEVELOPER_TOOLS")]
	public static void Warn(string tag, string format, params object[] args)
	{
		if(!string.IsNullOrEmpty(tag) && !enabledTags.Contains(tag)) return;
		Debug.LogWarningFormat(format, args);
	}
	
	[Conditional("DEVELOPER_TOOLS")]
	public static void Error(string tag, string format, params object[] args)
	{
		if(!string.IsNullOrEmpty(tag) && !enabledTags.Contains(tag)) return;
		Debug.LogErrorFormat(format, args);
	}

	[Conditional("DEVELOPER_TOOLS")]
	public static void Exception(string tag, Exception exception)
	{
		if(!string.IsNullOrEmpty(tag) && !enabledTags.Contains(tag)) return;
		Debug.LogException(exception);
	}

	[Conditional("DEVELOPER_TOOLS")]
	public static void EnableTag(string tag)
	{
		if(enabledTags.Contains(tag)) return;
		enabledTags.Add(tag);
	}

	[Conditional("DEVELOPER_TOOLS")]
	public static void DisableTag(string tag)
	{
		enabledTags.Remove(tag);
	}
}
