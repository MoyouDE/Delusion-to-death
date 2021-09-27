using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickToInvisible : MonoBehaviour, IPointerClickHandler
{
    public GameObject ClearObj;
    public List<GameObject> CleatTarget;
    public List<GameObject> ResetTarget;
    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log(eventData.pointerCurrentRaycast.gameObject);
        if (eventData.pointerCurrentRaycast.gameObject == ClearObj){
            if(ResetTarget.Count != 0)
            {
                foreach (GameObject obj in ResetTarget){
                    obj.SetActive(true);
                }
            }
            if(CleatTarget.Count == 0)
            {
                gameObject.SetActive(false);
            }
            else
            {
                foreach (GameObject obj in CleatTarget){
                    obj.SetActive(false);
                }
            }
        }


    }
}
