using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichCloset : MonoBehaviour
{
    public GameObject NormalCloset;
    public GameObject SpecialCloset;

    public State state;
    private Dictionary<string,bool> conditions;
    public void setActive(){
        conditions=state.conditions;
        foreach(KeyValuePair<string,bool> kv in conditions){
            if(kv.Key=="Clothes2")continue;
            if(kv.Value==false){
                NormalCloset.SetActive(true);
                return;
            }
        }
        SpecialCloset.SetActive(true);
    }
}
