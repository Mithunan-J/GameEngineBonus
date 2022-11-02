using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    int health = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        if(player.GetComponent<PlayerController>().attacking == true)
        {
            Hit();
            player.GetComponent<PlayerController>().attacking = false;
        }
    }
    public void Hit()
    {
        if(health == 2)
        {
            this.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            health -= 1;
        }
        else
        {
            Destroy(this.gameObject);
            PlayerDamageSingleton.instance.wallsRemaining -= 1;
        }
    }
}
