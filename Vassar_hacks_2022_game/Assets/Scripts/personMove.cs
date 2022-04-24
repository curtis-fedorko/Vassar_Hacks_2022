using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class personMove : MonoBehaviour
{
    private Animator anim;
    public float speed = 5f;
    public Rigidbody2D rb;
public float jumpAmount = 10;
public static string currentObject = ""; 
public static int health = 0; 
public string[] recycleobjects = new string[] {"waterbottle", "cardboard", "metal chair", "newspaper", "aerosol can"}; 
public string[] trashobjects = new string[] {"plastic bag", "styrofoam", "batteries", "wires", "lighter"}; 
public static int score = 0; 
public int recyclelevel = 0;  
    // Start is called before the first frame update
    void Start()
    {
        health = 100; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
        transform.Translate(Vector3.left * speed * Time.deltaTime); 
       // anim.SetBool("is_walking", true);
    }
     if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A)){
        transform.Translate(Vector3.right * speed * Time.deltaTime); 
       // anim.SetBool("is_walking", true);
    }
    if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)){
        transform.Translate(Vector3.up * speed * Time.deltaTime); 
      //  anim.SetBool("is_jumping", true);
    }
     if(Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
      //  anim.SetBool("is_jumping", true);
    }
  
        
    }

    void OnTriggerEnter2D(Collider2D other){
    
    if(other.CompareTag("bottle")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "waterbottle"; 
        recyclelevel = 1; 
    }

    if(other.CompareTag("cardboard")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "cardboard"; 
        recyclelevel = 1; 
    }
    if(other.CompareTag("metal chair")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "metal chair"; 
        recyclelevel = 1; 
    }
     if(other.CompareTag("newspaper")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "newspaper"; 
        recyclelevel = 1; 
    }
    if(other.CompareTag("aerosol can")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "aerosol can"; 
        recyclelevel = 1; 
    }
     if(other.CompareTag("plastic bag")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "plastic bag"; 
        recyclelevel = 2; 
    }
     if(other.CompareTag("styrofoam")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "styrofoam"; 
        recyclelevel = 2; 
    }
     if(other.CompareTag("batteries")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "batteries"; 
        recyclelevel = 2; 
    }
     if(other.CompareTag("wires")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "wires"; 
        recyclelevel = 2; 
    }
     if(other.CompareTag("lighter")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "lighter"; 
        recyclelevel = 2; 
    }

    if(other.CompareTag("recyclebin")){
        if(recyclelevel == 1){
            currentObject = ""; 
            recyclelevel = 0; 
            score++; 
        }
        else if(recyclelevel == 2){
            health -= 5; 
        } 
    }

    if(other.CompareTag("trashcan")){
        if(recyclelevel == 2){
            recyclelevel = 0; 
            currentObject = ""; 
            score++; 
        }
         else if(recyclelevel == 1){
            health -= 5; 
        } 
    }
    }

    public static int getHealth(){return health;}

    public static int getScore(){return score;}
}
