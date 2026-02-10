using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdolOfSholka : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator idolOfSholkaController;
    private SpriteRenderer sr;

    void Start()
    {
        idolOfSholkaController = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            idolOfSholkaController.SetBool("isTouching", true);
            idolOfSholkaController.SetBool("polkaCanMove", false);


        }
    }
}
