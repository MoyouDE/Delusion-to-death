using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class progress : MonoBehaviour
{
    public State state;
    private Text text;
    private int allCondition;
    private int nowCondition;
    private void Start() {
        text= GetComponent<Text>();
    }
    private void UpCon(){
        nowCondition=0;
        foreach (KeyValuePair<string,bool> b in state.conditions){
            if (b.Value==true)nowCondition++;
        }
        allCondition =state.conditions.Count;
    }
    public void Update()
    {
        UpCon();
        text.text= string.Format("{0}/{1}",nowCondition,allCondition);
    }
}
