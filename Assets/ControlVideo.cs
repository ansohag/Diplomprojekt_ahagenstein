using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ControlVideo : MonoBehaviour {

	public VideoPlayer vid;
	public string url;
	public GameObject button;

	public void Start()
	{
		vid.prepareCompleted += StartVideo;
	}
	
	public void SetUrl()
	{
		vid.url = url;
		vid.Prepare();
	}

	public void StartVideo(VideoPlayer vp)
	{
		vp.Play();
		button.SetActive(false);
	}

}
