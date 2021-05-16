﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerpitstop : MonoBehaviour
{
	public Text timerText;
	private float startTime;
	private bool finnished = false;
    
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
    	if(finnished)
    	return;
        float t = Time.time - startTime;
        string minutes = ((int) t /60 ).ToString();
        string sec = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + sec;
    }
    public void Finish()
    {
    	finnished = true;
        timerText.color = Color.red;
    }
}