using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    private int x = 0;
    private bool Event = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Event==false)
        Invoke("RandScene", 20.0f);
        Event = true;
    }

    void RandScene(){
        x = Random.Range(1, 4);

        if (x == 1)
        {
            Invoke("SceneChange", 1.0f);
        }
        if (x == 2)
        {
            Invoke("SceneChangeTurtle", 1.0f);
        }
        if (x == 3)
        {
            Invoke("SceneChangeCoral", 1.0f);
        }
    }
        void SceneChange()
    {

        SceneFade.FadeOut(2);
    }
    void SceneChangeTurtle()
    {
        SceneFade.FadeOut(3);
    }
    void SceneChangeCoral()
    {
        SceneFade.FadeOut(4);

    }

}

