using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PitStop : MonoBehaviour
{
   
    public GameObject PitStopUI;
    public GameObject GameModeUI;
    public GameObject trigger;
	private bool finished = false;
	public GameObject Timer;
 
    
    void OnTriggerEnter() 
    {
    	if (finished == false)
    	{
        	Debug.Log("aaah");
        	Timer.SetActive(true);
        	Pause();
        	
        }
    }
   
    public void Resume()
    {
        PitStopUI.SetActive(false);
        GameModeUI.SetActive(true);
        trigger.SetActive(false);
        Time.timeScale = 1f;
        
    }
    public void Pause()
    {
        PitStopUI.SetActive(true);
        GameModeUI.SetActive(false);
        Time.timeScale = 0f;
        
    }

}

