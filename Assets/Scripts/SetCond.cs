using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCond : MonoBehaviour
{
    public string Condition;
    public State state;

    public GameObject tip;
    public void setCondition(){
        if(state.conditions[Condition]==false){
            tip.SetActive(true);
            state.conditions[Condition]=true;
        }
    }
}
