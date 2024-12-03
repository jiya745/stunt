using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSlectionLeveltwo : MonoBehaviour
{
    public GameObject nextbtn;
    public GameObject wash, levelSelectionofpark, levelwash, menu;
    public GameObject loading, levelbtn, levelone;
    public static LevelSlectionLeveltwo inst;

    private void Awake()
    {
        if (inst == null)
        {
            inst = this;
        }
    }

    public void Start()
    {
        levelSelectionofpark.SetActive(false);
        PlayerPrefs.SetInt("1", 1); 
        PlayerPrefs.SetInt("2", 0); 
        PlayerPrefs.Save(); 

    }
    public void OnModeClick()
    {
        levelSelectionofpark.SetActive(false);
        wash.SetActive(true);
        nextbtn.SetActive(true);
        levelwash.SetActive(true);
       
        
        Invoke("menuuu", 2f);
    }
    public void menuuu()
    {
        levelSelectionofpark.SetActive(false);
        menu.SetActive(false);
    }

    public void levelSelectionModeTwo()
    {
        levelSelectionofpark.SetActive(false);
        menu.SetActive(false);
        if (PlayerPrefs.GetInt("2", 0) == 1)
        {
            menu.SetActive(false);
            levelwash.SetActive(true);
            levelSelectionofpark.SetActive(false);

        }
        // levelone.SetActive(true);
    }

    public void OnLevelOneClick()
    {
        levelbtn.SetActive(true);
    }

    public void OnPlayClick()
    {
        loading.SetActive(true); 
        SceneManager.LoadScene("PradoWash");
    }
}
