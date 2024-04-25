using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private bool PlayerInZone;
    public GameObject ceiling_light;
    public GameObject LightSwitches01;
    public AudioSource click;
    public AudioSource lights_on;
    public bool OnOff = false;

    private void Awake()
    {
        ///Debug.Log("awake");
    }


    private void Update()
    {
        if(PlayerInZone && Input.GetKeyDown(KeyCode.F)) {
            ceiling_light.SetActive(!ceiling_light.activeSelf);
            if(!OnOff) {
                LightSwitches01.transform.Rotate(10, 0, 0);
                OnOff = true;
            }
            else
            {
                LightSwitches01.transform.Rotate(-10, 0, 0);
                OnOff = false;
            }
            click.Play();
            Debug.Log(ceiling_light.gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = true;
            //Debug.Log("entering");
            if (!OnOff)
            {
                lights_on.Play();
            }
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
