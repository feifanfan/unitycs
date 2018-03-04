using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetwork : MonoBehaviour
{

    public int connections = 10;
    public int listenPort = 8899;
    public bool nat = false;
    // Use this for initialization
    void OnGUI()
    {
        if (Network.peerType == NetworkPeerType.Disconnected)
        {
            if (GUILayout.Button("创建服务器"))
            {
                NetworkConnectionError error = Network.InitializeServer(connections, listenPort, nat);
                print(error);
            }
            if (GUILayout.Button("链接服务器"))
            {

            }
        }
        else if (Network.peerType == NetworkPeerType.Server)
        {
            GUILayout.Label("服务器创建完成");
        }

    }
}
