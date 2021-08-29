using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveScene : MonoBehaviour
{
    public ChangeScene changeScene;
    public void LeaveSceneAnima()
    {
        changeScene.CloseSence();
    }
}
