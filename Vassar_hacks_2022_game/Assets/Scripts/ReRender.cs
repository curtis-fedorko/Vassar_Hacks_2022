using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReRender : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other){
        other.GetComponent<Renderer>().enabled = true;
}
}
