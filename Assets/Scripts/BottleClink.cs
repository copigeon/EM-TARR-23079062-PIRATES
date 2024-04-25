using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BottleClink : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}