using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuControl : MonoBehaviour
{
    [Header("Levels To Load")]
    public static string tracky = ""; 
    public string _cityLevel = "";
    public string _suburbsLevel = "";

void Update(){


}
    public void CityDialogYes(){
        tracky = "city"; 
        SceneManager.LoadScene("MainScene");
    }

    public void SuburbsDialogYes(){
        tracky = "burbs"; 
        SceneManager.LoadScene("MainScene");
    }

    public void QuitButton(){
        SceneManager.LoadScene("EndScene");
    }
}
