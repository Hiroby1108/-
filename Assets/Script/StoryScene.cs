using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScene : MonoBehaviour
{
    public float nextSceneCount = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nextSceneCount -= Time.deltaTime;
        if (nextSceneCount < 0)
        {
            SceneManager.LoadScene("tutorial");
        }
    }
}
