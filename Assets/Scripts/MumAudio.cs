using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MumAudio : MonoBehaviour
{
    public AudioSource mum;
    // Start is called before the first frame update
    void Awake()
    {
        mum.Play();
    }

}
