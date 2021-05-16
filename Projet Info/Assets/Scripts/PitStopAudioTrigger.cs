using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitStopAudioTrigger : MonoBehaviour
{
    void OnTriggerEnter() {

    FindObjectOfType<AudioManager>().Play("boxbox");
    } 
}
