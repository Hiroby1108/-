using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkControl : MonoBehaviour
{
    public GameObject obj;
    public AudioSource SE;
    public AudioClip firework;
    bool test;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audiosource = gameObject.GetComponent<AudioSource>();
        test =false;
    }

    // Update is called once per frame
    void Update()
    {
        if(test == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Instantiate(obj);
                SE.PlayOneShot(firework);
                test = true;
            }
        }
    }
}
