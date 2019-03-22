using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeStory : MonoBehaviour
{
    private bool Story = false;
    public Image Change;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Story == false)
            Invoke("Storys", 5.0f);
        Story = true;
    }
    void Storys()
    {
        this.ChangeStory(3.0f);
    }

    void ChangeStory(float duration)
    {
        this.Change.CrossFadeAlpha(0.0f, duration, false);
    }
    }
