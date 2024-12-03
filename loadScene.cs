using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    private void Start()
    {
        Invoke("load", 6f);
    }

    public void load()
    {
        SceneManager.LoadScene(1);
    }
}
