using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdolOfSholka : MonoBehaviour
{
    // Start is called before the first frame update
    private UIIdolTracker ui;
    private Animator idolOfSholkaController;
    private SpriteRenderer sr;

    void Start()
    {
        idolOfSholkaController = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        ui = GameObject.FindObjectOfType<UIIdolTracker>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ui.GetIdol();
            idolOfSholkaController.SetBool("isTouching", true);
            idolOfSholkaController.SetBool("polkaCanMove", false);

        }
    }
}
