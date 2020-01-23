using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Entscheidung : MonoBehaviour
{

    public VideoPlayer vid;
    public VideoPlayer entschVid;
    public string url;
    public string entschUrl;

    public GameObject startButton;
    public GameObject Entscheidung1;
    //public GameObject chooseRandom;
    public float timeWaited;
    public float time;
    public float maxTime = 5f;
    public float timeEntscheidung;
    public float maxTimeEntscheidung = 10f;

    public void Start()
    {
        vid.prepareCompleted += StartVideo;
        time = maxTime;
    }

    public void SetUrl()
    {
        vid.url = url;
        vid.Prepare();
    }

    public void StartVideo(VideoPlayer vp)
    {
        Debug.Log("Video is played");
        vp.Play();
        startButton.SetActive(false);
    }

    public void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else if (time <= 0)
        {
            Entscheidung1.SetActive(true);

            if (time > 0)
            {
                timeEntscheidung -= Time.deltaTime;
            }
            else if (time <= 0)
            {
                //   chooseRandom.SetActive(false);

            }
        }
    }
}