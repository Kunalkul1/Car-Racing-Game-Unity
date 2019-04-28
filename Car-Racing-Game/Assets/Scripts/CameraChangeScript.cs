using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraScript : MonoBehaviour
{

    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;

    IEnumerator changeCamMode()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if (CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }

    }

    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode = CamMode + 1;
            }
            StartCoroutine(changeCamMode());
        }
    }
}