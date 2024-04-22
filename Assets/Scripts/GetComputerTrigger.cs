using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComputerTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by " + other.gameObject.name);
    }
}
