using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class enem : MonoBehaviour
{

    
    [DllImport("__Internal")]
    private static extern void JoinRoomWRTC(string str);
    
    
    [DllImport("__Internal")]
    private static extern void LeaveRoomWRTC();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("blabla");
        string randomRoom = "room-653453";
        JoinRoomWRTC(randomRoom); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
