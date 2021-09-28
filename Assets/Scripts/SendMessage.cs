using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    public List<string> key;
    public State state ;
    public string ConKey;
    public void sendMessage()
    {
        if (key!=null)
        {
            if(ConKey!=null){
                if(state.conditions[ConKey])return;
            }
            SendMessageUpwards("GetMessage", key, SendMessageOptions.DontRequireReceiver);
        }
    }
}
