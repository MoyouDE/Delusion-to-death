using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickSound : MonoBehaviour
{
    public AudioSource ClickAudio;
    private void Update() {
        if(Input.GetMouseButton(0)){
        ClickAudio.Play();}
    }
}
