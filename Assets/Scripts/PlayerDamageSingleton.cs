using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageSingleton : MonoBehaviour
{
    int playerHealth = 3;
    public List<GameObject> hearts;
    // Start is called before the first frame update
    public static PlayerDamageSingleton instance;
    public GameObject winPanel;
    public GameObject losePanel;
    public int wallsRemaining = 1;

    void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(wallsRemaining == 0)
        {
            winPanel.SetActive(true);
        }
    }
    public int GetPlayerHealth()
    {
        return playerHealth;
    }

    public void PlayerAttacked()
    {
        if(playerHealth > 0)
        {
            Debug.Log("Hit");
            playerHealth -= 1;
            Destroy(hearts[playerHealth]);
        }
        if(playerHealth == 0)
        {
            losePanel.SetActive(true);
        }
    }
}
