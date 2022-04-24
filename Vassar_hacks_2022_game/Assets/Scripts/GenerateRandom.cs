using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandom : MonoBehaviour
{
     public GameObject[] newObject;
     public float timey = 0f; 
     public float objecttimey = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timey += Time.deltaTime;
        objecttimey += Time.deltaTime; 
        
        if(timey >= 7){
            float randomtime = Random.Range(0f, 1f); 
            if(randomtime >= .5){
            SpawnNewRecycle(); 
            } 
            if(randomtime < .5){
            SpawnNewTrash(); 
            }
            timey = 0; 
        }
        if(objecttimey >= 5){
            SpawnNewObject(); 
            objecttimey = 0; 
        }
    }

    public void SpawnNewRecycle(){
        GameObject nc = Instantiate(newObject[0], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(-6.8f, -5.8f, -1f);

    }

    public void SpawnNewTrash(){
        GameObject nc = Instantiate(newObject[1], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(-6.8f, -5.8f, -1f);

    }

    public void SpawnNewObject(){
        int rannum = Random.Range(2,11);
        GameObject nc = Instantiate(newObject[rannum], this.transform) as GameObject; 
        nc.GetComponent<Renderer>().enabled = true;
        nc.transform.localPosition = new Vector3(-9.5f, -3.8f, -1f);

    }
   
}
