using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCereal : MonoBehaviour
{
    private bool PlayerInZone;
    public bool OnOff = false;
    private Animator anim;
    public AudioSource shake_cereal1;
    public AudioSource shake_cereal2;
    public AudioSource cereal_grab;
    public AudioSource oh_no_cereal;
    public AudioSource trigger;

    private void Awake()
    {
        ///Debug.Log("awake");
        anim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log(this.gameObject.name);
            if (OnOff == false)
            {
                anim.SetTrigger("Activate");
                if (this.gameObject.name == "cereal")
                {
                    OnOff = true;
                }
            }
        }
    }

    private void OnShake()
    {
        shake_cereal1.Play();
    }
    private void OnGrab()
    {
        cereal_grab.Play();
    }
    private void NoCereal()
    {
        oh_no_cereal.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = true;
            ////Debug.Log("entering1");
            if (OnOff == false)
            {
                if (!trigger.isPlaying)
                {
                    trigger.Play();
                }
            }
        }
        //Debug.Log("entering");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            ///Debug.Log("leaving");
        }
        //Debug.Log("leaving1");

    }

}
