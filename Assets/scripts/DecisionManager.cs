using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class DecisionManager : MonoBehaviour
{

    public VideoClip[] videoclips;
    public VideoPlayer videoPlayer;
    public int number = 0;
    public float time;
    public float[] maxTime;
    public bool timeRunning;
    public GameObject[] EntscheidungsButtons;

    // Use this for initialization
    void Start()
    {
        //wenn Ende des Videos erreicht ist wird Funktion PlayVideos aufgerufen
        videoPlayer.loopPointReached += NextVideo;
    }

    public void NextVideo(VideoPlayer vid)
    {
        //Wenn Video Nummer unter 3 ist wird immer wieder das Nummer darauffolgende Video abgespiet 
        if (number < 3)
        {
            videoPlayer.clip = videoclips[number];
            videoPlayer.Play();
            EntscheidungsButtons[number].SetActive(false); // Buttons werden ausgeblendet
            number = number + 1;
            timeRunning = true;
        }
        //Wenn es drüber ist dann wird nicht mehr dazugerechnet 
        else
        {
            //zeigt das wir keine Videos mehr haben, Ende ist erreicht 
            Debug.Log("End Reached");
        }
    }

    public void SetTimerActive()
    {
        timeRunning = true;
    }


    // Update is called once per frame
    void Update()
    {
        //wenn der Start button gedrückt wird bzw set active is true dann startet der Timer zu zählen
        if (timeRunning)
        {
            //wenn die Zeit noch größer 0 ist wird Zeit abgezogen
            if (maxTime[number] > 0)
            {
                maxTime[number] -= Time.deltaTime;
            }
            //zeit ist abgelaufen 
            else
            {
                Debug.Log("Time is up");
                EntscheidungsButtons[number].SetActive(true);
                timeRunning = false;
            }
        }

    }

    public void NewVideo(VideoClip videoVariable)
    {
        videoclips[0] = videoVariable;
    }
}
