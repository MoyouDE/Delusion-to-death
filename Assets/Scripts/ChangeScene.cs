using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene:MonoBehaviour
{
    public SceneProperty defaultScence;
    public Transform changeBT;
    public Animation maskAnima;
    [SerializeField]
    private SceneProperty curScene;
    private SceneProperty taegetScene;
    public enum dir
    {
        right,
        left,
        front,
        back
    }
    private void Start()
    {
        init();
    }
    /// <summary>
    /// ��ť�߼�
    /// </summary>
    /// <param name="direction"></param>
    public void changeScene(int direction)
    {
        
        switch (direction)
        {
            case (int)dir.left:
                {
                    OpenScene(curScene.leftScene);
                    break;
                }
            case (int)dir.right:
                {
                    OpenScene(curScene.rightScene);
                    break;
                }
            case (int)dir.front:
                {
                    OpenScene(curScene.frontScene);
                    break;
                }
            case (int)dir.back:
                {
                    OpenScene(curScene.backScene);
                    break;
                }
        }
    }
    /// <summary>
    /// ����ת����Ч
    /// </summary>
    private void LeaveSceneAnima()
    {
        
        maskAnima.Play();
    }
    /// <summary>
    /// �رճ���
    /// </summary>
    public void CloseSence()
    {
        curScene.gameObject.SetActive(false);
        taegetScene.gameObject.SetActive(true);
        curScene = taegetScene;
        SetArrow();
        taegetScene = null;
    }
    /// <summary>
    /// ������ʼ��
    /// </summary>
    private void OpenScene(SceneProperty taeget)
    {
        LeaveSceneAnima();
        taegetScene = taeget;  
    }
    /// <summary>
    /// �����Ƿ���ʾ��ͷ
    /// </summary>
    private void SetArrow()
    {
        Transform[] arrows = changeBT.GetComponentsInChildren<Transform>(true);
        arrows[1].gameObject.SetActive(curScene.leftScene != null);
        arrows[2].gameObject.SetActive(curScene.rightScene != null);
        arrows[3].gameObject.SetActive(curScene.frontScene != null);
        arrows[4].gameObject.SetActive(curScene.backScene != null);
    }

    private void init()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        defaultScence.gameObject.SetActive(true);
        curScene = defaultScence;
        SetArrow();
    }
}
