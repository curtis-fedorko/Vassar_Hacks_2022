using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    [Header("Levels To Load")]
    public string _cityLevel = "";
    public string _suburbsLevel = "";

    public void CityDialogYes(){
        SceneManager.LoadScene(_cityLevel);
    }

    public void SuburbsDialogYes(){
        SceneManager.LoadScene(_suburbsLevel);
    }

    public void QuitButton(){
        Application.Quit();
    }
}
