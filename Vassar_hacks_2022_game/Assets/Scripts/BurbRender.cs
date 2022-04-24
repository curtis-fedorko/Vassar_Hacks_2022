using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurbRender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(menuControl.tracky == "burbs"){
        this.GetComponent<Renderer>().enabled = true;
        }
        if(menuControl.tracky == "city"){
        this.GetComponent<Renderer>().enabled = false;
        }
    }


}
