using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject TextToDisplay; // text on screen
    private bool PlayerInZone;

    public GameObject ceiling_light;

    private void Start()
    {
        PlayerInZone = false;
        TextToDisplay.SetActive(false);
    }

    private void Update()
    {
        if(PlayerInZone && Input.GetKeyDown(KeyCode.F)) {
            ceiling_light.SetActive(!ceiling_light.activeSelf);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerCapsule")
        {
            TextToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PlayerCapsule")
        {
            PlayerInZone = false;
            TextToDisplay.SetActive(false);
        }
    }

}
