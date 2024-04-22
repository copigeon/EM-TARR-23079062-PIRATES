using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private bool PlayerInZone;
    public GameObject ceiling_light;

    private void Awake()
    {
        ///Debug.Log("awake");
    }


    private void Update()
    {
        if(PlayerInZone && Input.GetKeyDown(KeyCode.F)) {
            ceiling_light.SetActive(!ceiling_light.activeSelf);
            //Debug.Log(ceiling_light.gameObject.name);
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
