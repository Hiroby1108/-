using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource SE;
    public AudioClip take;
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
        if (collision.gameObject.tag == "Area")
        {
            SE.PlayOneShot(take);
        }
    }
    
}
