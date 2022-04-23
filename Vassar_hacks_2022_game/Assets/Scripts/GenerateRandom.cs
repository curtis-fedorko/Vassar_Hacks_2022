using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandom : MonoBehaviour
{
     public GameObject[] newObject;
     public float timey = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timey += Time.deltaTime;
        
        if(timey >= 15){
            float randomtime = Random.Range(0f, 1f); 
            if(randomtime >= .5){
            SpawnNewRecycle(); 
            } 
            if(randomtime < .5){
            SpawnNewTrash(); 
            }
            timey = 0; 
        }
    }

    public void SpawnNewRecycle(){
        GameObject nc = Instantiate(newObject[0], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(-6.8f, -5.8f, 107963.7f);

    }

    public void SpawnNewTrash(){
        GameObject nc = Instantiate(newObject[2], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(-6.8f, -5.8f, 107963.7f);

    }
   
}
