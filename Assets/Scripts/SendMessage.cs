using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    public List<string> key;

    public void sendMessage()
    {
        if (key!=null)
        {
            SendMessageUpwards("GetMessage", key, SendMessageOptions.DontRequireReceiver);
        }
    }
}
