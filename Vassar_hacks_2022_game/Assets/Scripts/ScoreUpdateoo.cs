using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdateoo : MonoBehaviour
{
    public Text score; 

    // Update is called once per frame
    void Update()
    {
        int scorey = personMove.score; 
        score.text = scorey.ToString("0"); 
        
    }
}
