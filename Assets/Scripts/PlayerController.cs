using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 15f;
    public bool ladderPresent = false;
    public bool attacking = false;
    public int health = 3;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = -Vector2.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) && ladderPresent)
        {
            rb.velocity = Vector2.up * speed * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            attacking = true;
        }
        
    }
    
    public void Attacked()
    {
        health -= 1;
    }
}
