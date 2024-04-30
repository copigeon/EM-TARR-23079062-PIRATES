using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinenapplePlay : MonoBehaviour
{
    public AudioSource trigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("entering pineapple");
            if (!trigger.isPlaying)
            {
                trigger.Play();
                Debug.Log("entering pineapple play");

            }
        }
        //Debug.Log("entering");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("leaving");
        }
        //Debug.Log("leaving");

    }
}
