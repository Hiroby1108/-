using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public AudioSource SE;
    public AudioClip start;
    
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audiosource = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SE.PlayOneShot(start);
        }
    }
    }
