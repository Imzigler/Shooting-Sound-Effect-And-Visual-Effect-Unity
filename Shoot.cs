using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Particle;
    public AudioSource bulletSound;
    public AudioClip singleshot;
    public AudioClip shots;
    public GameObject maincamera;
    public GameObject fpscamera;
    void Start()
    {
        bulletSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("left click");
            Particle.GetComponent<ParticleSystem>().Play();
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("right click");
            //switch camera 
            if (maincamera.active == true)
            {
                maincamera.SetActive(false);
                fpscamera.SetActive(true);
            }
            else if(maincamera.active == false)
            {
                maincamera.SetActive(true);
                fpscamera.SetActive(false);
            }
        }
        if (Input.GetMouseButton(2))
        {
            Debug.Log("middle click");
        }
        if (Input.GetMouseButtonDown(0))
        {
            //this on holding click
            //on hold click shoot :
            shoots();
        }
        if (Input.GetMouseButtonUp(0))
        {
            //when you stop holding the button 0
            //on hold click leftup stop shooting :
            stopshoots();
        }

    }
    

    public void shoots()
    {
        Particle.GetComponent<ParticleSystem>().Play();
        if (!bulletSound.isPlaying)
        {
            bulletSound.PlayOneShot(shots);
        }        
    }public void stopshoots()
    {
        if (bulletSound.isPlaying)
        {
            bulletSound.Stop();
        }        
    }


}
