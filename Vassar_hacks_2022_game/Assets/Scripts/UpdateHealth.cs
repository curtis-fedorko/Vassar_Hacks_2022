using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateHealth : MonoBehaviour
{
    public Text score; 

    // Update is called once per frame
    void Update()
    {
        int scorey = personMove.getHealth(); 
        score.text = scorey.ToString("0"); 
        
    }
}
