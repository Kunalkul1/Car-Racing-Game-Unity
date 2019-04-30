using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeScript : MonoBehaviour
{

    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;

    IEnumerator changeCamMode()
    {
        yield return new WaitForSeconds(0.01f);
        switch(CamMode)
        {
        	case 0:
	        	NormalCam.SetActive(true);
	            FPCam.SetActive(false);	
	            break;
	        case 1:
	        	FarCam.SetActive(true);
            	NormalCam.SetActive(false);
            	break;
	        case 2:
	        	FPCam.SetActive(true);
            	FarCam.SetActive(false);	    
            	break;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
        	switch(CamMode)
        	{
        		case 2:
        			CamMode = 0;
        			break;
        		default:
        			CamMode = CamMode + 1;
        			break;
        	}
            StartCoroutine(changeCamMode());
        }
    }
}