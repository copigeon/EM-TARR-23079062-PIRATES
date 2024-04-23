using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivate : MonoBehaviour
{
    private bool PlayerInZone;
    public bool OnOff = false;

    private void Awake()
    {
        ///Debug.Log("awake");
    }


    private void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = true;
            //Debug.Log("entering");
        }
        //Debug.Log("entering");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            //Debug.Log("leaving");
        }
        //Debug.Log("leaving");

    }

}
