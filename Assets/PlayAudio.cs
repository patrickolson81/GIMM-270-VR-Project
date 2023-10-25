using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] private AudioSource audio;


    private void OnCollisionEnter(Collision collision)
    {
        audio.Play();
    }
}
