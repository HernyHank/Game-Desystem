using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopTrigger : MonoBehaviour
{
    private UISlopTracker ui;

    private void Awake()
    {
        ui = GameObject.FindObjectOfType<UISlopTracker>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ui.GetCoin();

            Destroy(gameObject);
        }

    }

}
