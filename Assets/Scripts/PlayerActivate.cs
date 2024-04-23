using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivate : MonoBehaviour
{
    private bool PlayerInZone;
    public bool OnOff = false;
    private Animator anim;



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
            if(OnOff == false)
            {
                anim.SetTrigger("Activate");
                if (this.gameObject.name == "SodaStream")
                {
                    OnOff = true;
                }
            }
        }
    }

    private void OnEnd()
    {
        anim.Play("Dispense Bottle", 0, 787f);
        anim.speed = 0f;
        Vector3 oldpos = gameObject.transform.Find("Bottle").position;
        Quaternion oldrot = gameObject.transform.Find("Bottle").rotation;
        gameObject.transform.Find("Bottle").SetParent(null,true);
        UnityEngine.GameObject.Find("Bottle").transform.SetLocalPositionAndRotation(oldpos, oldrot);
        //UnityEngine.GameObject.Find("Bottle").transform.rotation = oldrot;
        //UnityEngine.GameObject.Find("Bottle").transform.position = oldpos;


        //GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        //foreach (object go in allObjects)
        //{ print(go + " is an active object"); }

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