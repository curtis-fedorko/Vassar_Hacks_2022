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
public string currentObject = ""; 
public static int health = 0; 
public string[] recycleobjects = {"waterbottle"}; 
public static int score = 0; 
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
        anim.SetBool("is_walking", true);
    }
     if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A)){
        transform.Translate(Vector3.right * speed * Time.deltaTime); 
        anim.SetBool("is_walking", true);
    }
    if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)){
        transform.Translate(Vector3.up * speed * Time.deltaTime); 
        anim.SetBool("is_jumping", true);
    }
     if(Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
        anim.SetBool("is_jumping", true);
    }
  
        
    }
    void OnTriggerEnter2D(Collider2D other){
    
    if(other.CompareTag("bottle")){
        other.GetComponent<Renderer>().enabled = false;
        currentObject = "waterbottle"; 
    }

    if(other.CompareTag("recyclebin")){
        if(Array.BinarySearch(recycleobjects,currentObject) >= 0){
            currentObject = ""; 
            score++; 
        }
        else{
            health--; 
        } 
    }

    }

    public static int getHealth(){return health;}

    public static int getScore(){return score;}
}
