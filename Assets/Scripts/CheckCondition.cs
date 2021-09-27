using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckCondition : MonoBehaviour
{
    public Dictionary<string,GameObject> ImgConds;
    public State state;

    public Animation CloseaAnime;

    [System.Serializable]
    public struct condition
    {
        public string key;
        public GameObject value;
    }
    public condition[] conditionPrefbs;

    private void IntDic()
    {
        // 字典内容
        ImgConds = new Dictionary<string, GameObject>();
        for (int i = 0; i < conditionPrefbs.Length; i++)
        {
            if (!ImgConds.ContainsKey(conditionPrefbs[i].key))
            {
                ImgConds.Add(conditionPrefbs[i].key, conditionPrefbs[i].value);
            }
        }
    }

    private void OnEnable() {
        IntDic();
        foreach(KeyValuePair<string,GameObject> ImgCond in ImgConds){
            ImgCond.Value.SetActive(!state.conditions[ImgCond.Key]);
        }
    }

    private void OnDisable() {
        foreach(KeyValuePair<string,bool> kv in state.conditions){
            if(kv.Value==false)return;
        }
        CloseaAnime.Play();
    }
}
