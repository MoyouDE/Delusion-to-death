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

    private string FileCSV(string _str)
    {
        string path = "";
#if UNITY_EDITOR
        path = Application.dataPath + "/Messages/" + _str + ".csv";
#endif
        return path;
    }

    private void readCSV()
    {
        string path = FileCSV("messages");
        if (File.Exists(path))
        {
            StreamReader srReadFile = new StreamReader(path);
            srReadFile.ReadLine();//忽略第一行
            while (!srReadFile.EndOfStream)
            {
                string[] value = srReadFile.ReadLine().Split(',');
                messages.Add(value[1], value[2]);               
            }
            // 关闭读取流文件
            srReadFile.Close();
        }
    }
}
