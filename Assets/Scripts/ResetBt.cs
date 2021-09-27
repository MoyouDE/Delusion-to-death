using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetBt : MonoBehaviour
{
    private void OnDisable() {
       GetComponent<Button>().interactable=true;
   }
}
