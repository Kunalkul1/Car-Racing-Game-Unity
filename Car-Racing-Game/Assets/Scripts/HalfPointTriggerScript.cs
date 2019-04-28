using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTriggerScript : MonoBehaviour {
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter()
    {
    	HalfLapTrig.SetActive(false);
        LapCompleteTrig.SetActive(true);
    }
}
