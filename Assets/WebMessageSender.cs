using UnityEngine;
using System.Runtime.InteropServices;

public class WebMessageSender : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void myJavaScriptFunction(string message);


    public void SendData()
    {
#if UNITY_WEBGL && !UNITY_EDITOR

            myJavaScriptFunction("Unity'den gelen parametre");
#endif


    }
}
