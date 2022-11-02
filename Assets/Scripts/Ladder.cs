using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Mario");
        player.GetComponent<PlayerController>().ladderPresent = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Mario");
        player.GetComponent<PlayerController>().ladderPresent = false;
    }
}
