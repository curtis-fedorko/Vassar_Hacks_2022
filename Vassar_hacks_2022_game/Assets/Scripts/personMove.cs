using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class personMove : MonoBehaviour
{
    private Animator anim;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
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
    if(Input.GetKey(KeyCode.Space)){
        transform.Translate(Vector3.up * speed * Time.deltaTime); 
        anim.SetBool("is_jumping", true);
    }
        
    }
    void OnTriggerEnter2D(Collider2D other){
    
    if(other.CompareTag("bottle")){
        other.GetComponent<Renderer>().enabled = false;
    }
    }
}
