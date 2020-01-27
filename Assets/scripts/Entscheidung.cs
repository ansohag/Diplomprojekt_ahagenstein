﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Entscheidung : MonoBehaviour
{

    public VideoPlayer vid;
    public VideoPlayer entsch1Vid;
    public string url;
    public string entsch1Url;

    public GameObject startButton;
    public GameObject Entscheidung1;
    public GameObject chooseRandom;
    public float timeWaited;
    public float time;
    public float maxTime = 5f;
    public float timeEntscheidung;
    public float maxTimeEntscheidung = 10f;

    public GameObject videoAntworten;
    public GameObject videoNichtAntworten;

    public void Start()
    {
        vid.prepareCompleted += StartVideo;
        time = maxTime;
        timeEntscheidung = maxTimeEntscheidung;
    }

    public void SetUrl()
    {
        vid.url = url;
        vid.Prepare();
    }
    public void SetEntschUrl()
    {
        entsch1Vid.url = entsch1Url;
        vid.Prepare();
    }
    public void StartVideo(VideoPlayer vp)
    {
        Debug.Log("Video is played");
        vp.Play();
        startButton.SetActive(false);
    }

    public void StartEntschVideo(VideoPlayer vp)
    {
        Debug.Log("Entsch1 is played");
        vp.Play();
        videoAntworten.SetActive(false);
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

            if (timeEntscheidung > 0)
            {
                timeEntscheidung -= Time.deltaTime;
            }
            else if (timeEntscheidung <= 0)
            {
                chooseRandom.SetActive(false);

            }
        }

    }
}