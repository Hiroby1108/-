using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource SE;
    public AudioClip take;
    public AudioClip warning;
    public AudioClip back;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audiosource = gameObject.GetComponent<AudioSource>();   
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trash")
        {
            SE.PlayOneShot(take);
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
      
            if (other.gameObject.name == "SafetyArea")
            {
                SE.PlayOneShot(warning);
            }
        if (other.gameObject.name == "PlayArea")
        {
            SE.PlayOneShot(back);
        }
    }
    

}
