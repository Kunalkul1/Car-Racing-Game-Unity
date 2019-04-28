using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class LapCompleteScript : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;
    public GameObject LapCounter;
    public int laps;

    void OnTriggerEnter()
    {
        laps = laps + 1;
        if (LapTimeManagerScript.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManagerScript.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManagerScript.SecondCount + ".";
        }

        if (LapTimeManagerScript.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManagerScript.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManagerScript.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManagerScript.MilliCount;

        LapTimeManagerScript.MinuteCount = 0;
        LapTimeManagerScript.SecondCount = 0;
        LapTimeManagerScript.MilliCount = 0;
        LapCounter.GetComponent<Text>().text = "" + laps;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}
