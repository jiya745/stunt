using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionModeTwo : MonoBehaviour
{
    public GameObject nextbtn,menu;
    public GameObject park;
    public GameObject  loading, levelbtn, levelone;
    public static LevelSelectionModeTwo ins;
    private void Awake()
    {
        if (ins == null)
        {
            ins = this;
        }
    }
    public void Start()
    {
        
        PlayerPrefs.SetInt("1", 1);
        PlayerPrefs.SetInt("2", 0);
        PlayerPrefs.Save();

    }


    public void OnModeClick()
    {

        park.SetActive(true);
        nextbtn.SetActive(true);
        Invoke("menuuu", 2f);
    }

    public void menuuu()
    {
        menu.SetActive(false);
    }

    
    public void OnStartLevelSelectionClick()
    {
      menu.SetActive(false);
        if (PlayerPrefs.GetInt("1", 0) == 1)
        {
            menu.SetActive(false);
            loading.SetActive(false);
            levelone.SetActive(true);
        }
           
    }

  
    public void OnLevelOneClick()
    {
    
        levelbtn.SetActive(true);  
    }

   
    public void OnPlayClick()
    {
        loading.SetActive(false);
        SceneManager.LoadScene("PradoParking"); 
    }
}
