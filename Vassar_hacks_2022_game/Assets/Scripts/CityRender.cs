using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityRender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(menuControl.tracky == "burbs"){
        this.GetComponent<Renderer>().enabled = false;
        }
        if(menuControl.tracky == "city"){
        this.GetComponent<Renderer>().enabled = true;
        }
    }
}
