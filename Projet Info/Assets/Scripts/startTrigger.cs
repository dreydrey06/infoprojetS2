using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTrigger : MonoBehaviour
{
 void OnTriggerEnter() {

    FindObjectOfType<AudioManager>().Play("ItsLightsOut");
    } 
}
