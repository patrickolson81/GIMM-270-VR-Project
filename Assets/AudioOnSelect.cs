using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnSelect : MonoBehaviour
{
    [SerializeField] AudioSource m_Source;

    
    void Start()
    {

    }
    
    public void Play()
    {
        if (gameObject == this)
        {
            m_Source.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
