using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetAlpha : MonoBehaviour
{
    void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }
}
