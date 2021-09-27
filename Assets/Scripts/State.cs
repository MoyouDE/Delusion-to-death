using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class State : MonoBehaviour
{
    public Dictionary<string,bool> conditions;
    [System.Serializable]
    public struct condition
    {
        public string key;
        public bool value;
    }

    public condition[] conditionPrefbs;

    private void Start()
    {
        // 字典内容
        conditions = new Dictionary<string, bool>();
        for (int i = 0; i < conditionPrefbs.Length; i++)
        {
            if (!conditions.ContainsKey(conditionPrefbs[i].key))
            {
                conditions.Add(conditionPrefbs[i].key, conditionPrefbs[i].value);
            }
        }
    }
}
