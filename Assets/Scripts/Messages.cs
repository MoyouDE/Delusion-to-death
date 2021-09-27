using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Messages : MonoBehaviour
{
    public static Dictionary<string, string> messages;
    private void Start()
    {
        messages = new Dictionary<string, string>();
        readCSV();
        //foreach(KeyValuePair<string,string> kvp in messages)
        //{
        //    Debug.Log(kvp.key+" "+kvp.Value);
        //}
    }

    private string[] FileCSV(string _str)
    {
    //读取csv二进制文件
    TextAsset binAsset = Resources.Load (_str, typeof(TextAsset)) as TextAsset;
    //读取每一行的内容
    string [] lineArray = binAsset.text.Split ("\n"[0]);
    return lineArray;
    }

    private void readCSV()
    {
        string[] File = FileCSV("messages");
        if (File!=null)
        {
            for(int i =2;i < File.Length; i++)
            {
                string[] value = File[i].Split(',');
                messages.Add(value[0], value[1]);
            }
        }
    }
}
