using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessageAfterCheck : MonoBehaviour
{
    public List<String> key;
    public State state;
    private Dictionary<string,bool> conditions;
    public void sendMessage()
    {
        Type t = Type.GetType("SendMessageAfterCheck");
        if (key != null)
        {
            System.Reflection.MethodInfo method = t.GetMethod(key[0]);
            method.Invoke(this, null);
        }
    }
    public void closet_begin_01()
    {
        conditions=state.conditions;
        foreach(KeyValuePair<string,bool> kv in conditions){
            if(kv.Key=="Clothes2")continue;
            if(kv.Value==false){
                List<string> tmp = new List<string>();
                tmp.Add(key[0]);
                SendMessageUpwards("GetMessage", tmp, SendMessageOptions.DontRequireReceiver);
                return;
            }
        }
        List<string> tmp1 = new List<string>();
        tmp1.Add(key[1]);
        SendMessageUpwards("GetMessage", tmp1, SendMessageOptions.DontRequireReceiver);
    }
}