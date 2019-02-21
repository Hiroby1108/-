using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkControl : MonoBehaviour
{
    public GameObject obj;
    public AudioSource SE;
    public AudioClip firework;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource audiosource = gameObject.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(obj);
            SE.PlayOneShot(firework);
        }
    }
}
