#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class UnityUDPListener : MonoBehaviour
{
    void Start()
    {
        MyUdpClient.Init((string shaderCode) =>
        {
            AssetDatabase.Refresh();
        });
    }
}
#endif