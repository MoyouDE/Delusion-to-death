using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessageAfterCheck : MonoBehaviour
{
    public List<String> key;
    public void sendMessage()
    {
        Type t = Type.GetType("SendMessageAfterCheck");
        if (key != null)
        {
            System.Reflection.MethodInfo method = t.GetMethod(key[0]);
            method.Invoke(this, null);
        }
    }
    public void test2()
    {
        SendMessageUpwards("GetMessage", key, SendMessageOptions.DontRequireReceiver);
    }
}