using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessage : MonoBehaviour
{
    public string key;
    public void sendMessage()
    {
        if (key!=null)
        {
            SendMessageUpwards("GetMessage", key, SendMessageOptions.DontRequireReceiver);
        }
    }
}
