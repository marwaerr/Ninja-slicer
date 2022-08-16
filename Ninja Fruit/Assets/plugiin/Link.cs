using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void Opendiscord()
	{
#if !UNITY_EDITOR
		openWindow("https://discord.com/channels/@me");
#endif
	}
	public void Opengithub()
	{
#if !UNITY_EDITOR
		openWindow("https://github.com/marwaerr");
#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}