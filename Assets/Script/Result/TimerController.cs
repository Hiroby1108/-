using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    [SerializeField]
    public Text TimerText;
    [SerializeField]
    public float TotalTime;
    int Seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime -= Time.deltaTime;
        Seconds = (int)TotalTime;
        TimerText.text = Seconds.ToString();
        if (TotalTime<0)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
