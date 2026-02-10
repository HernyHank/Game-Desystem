using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidOutTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform respawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.transform.position = respawnPoint.position;
        }
    }
}
