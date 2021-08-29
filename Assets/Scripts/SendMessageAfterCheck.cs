using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessageAfterCheck : MonoBehaviour
{
    public string key;
    private delegate void ConditionCheck();
    public void sendMessage()
    {
        Type t = Type.GetType("SendMessageAfterCheck");
        if (key != null)
        {
            System.Reflection.MethodInfo method = t.GetMethod(key);
            method.Invoke(this, null);
        }
    }
    public void test2()
    {
        SendMessageUpwards("GetMessage", key, SendMessageOptions.DontRequireReceiver);
    }
}