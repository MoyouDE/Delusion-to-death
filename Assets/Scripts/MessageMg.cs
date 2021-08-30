using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MessageMg : MonoBehaviour
{
    public Text messageBox;
    public Image controlMask;
    [SerializeField]
    private bool canClick;
    private List<string> messageKey;
    private int curIndex;
    private Sequence mySequence;
    /// <summary>
    /// 清除文本内容
    /// </summary>
    public void Clear()
    {
        messageBox.text = "";
    }

    private void GetMessage(List<string> messageKey)
    {
        controlMask.gameObject.SetActive(true);
        curIndex = 0;
        canClick = false;
        this.messageKey = messageKey;
        Clear();
        mySequence = DOTween.Sequence();
        mySequence.Append(messageBox.DOText(Messages.messages[messageKey[curIndex]], 1));
        mySequence.AppendCallback(() => { curIndex++; canClick = true; });
        mySequence.Play();
    }

    public void ClickMask()
    {
        if (canClick)
        {
            if (curIndex >= messageKey.Count)
            {
                controlMask.gameObject.SetActive(false);
                return;
            }
            Clear();
            canClick = false;
            mySequence = DOTween.Sequence();
            mySequence.Append(messageBox.DOText(Messages.messages[messageKey[curIndex]], 1));
            mySequence.AppendCallback(() => { curIndex++; canClick = true; });
            mySequence.Play();
        }
    }
}
