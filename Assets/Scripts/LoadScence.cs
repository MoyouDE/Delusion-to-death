using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScence : MonoBehaviour
{
    public void Load(string ScenceName)
    {
        SceneManager.LoadScene(ScenceName);
    }
}
