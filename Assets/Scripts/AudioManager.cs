using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip AudioObj1;
    public AudioClip AudioObj2;
    public AudioClip AudioObj3;
    public AudioClip AudioObj4;
    public AudioClip AudioObj5;
    public AudioClip AudioObj6;
    public AudioClip AudioObj7;

    public AudioSource g_Audio;

   
    // Start is called before the first frame update
    void Start()
    {
      // g_Audio = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        m_PlayAudio();
    }


    void m_PlayAudio()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            g_Audio.clip = AudioObj1;   
            g_Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            g_Audio.clip = AudioObj2;
            g_Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            g_Audio.clip = AudioObj3;
            g_Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            g_Audio.clip = AudioObj4;
            g_Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            g_Audio.clip = AudioObj5;
            g_Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            g_Audio.clip = AudioObj6;
            g_Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            g_Audio.clip = AudioObj7;
            g_Audio.Play();
        }
    }
}
