using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MessageMg : MonoBehaviour
{
    public Text messageBox;

    /// <summary>
    /// ����ı�����
    /// </summary>
    private void Clear()
    {
        messageBox.text = "";
    }
    private void GetMessage(string messageKey)
    {
        messageBox.text = Messages.messages[messageKey];
    }
}
