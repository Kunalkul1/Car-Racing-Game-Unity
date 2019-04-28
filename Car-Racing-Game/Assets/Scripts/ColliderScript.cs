using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Vehicles.Car;

public class ColliderScript : MonoBehaviour {

	public GameObject CrashCube;
	public GameObject MyCar;
	public GameObject ViewModes;
	public AudioSource bgMusic;
	bool flag = false;

	IEnumerator OnTriggerEnter () {
		
		this.GetComponent<BoxCollider>().enabled = false;
		MyCar.SetActive(false);
		CarController.m_Topspeed = 0.0f;
		MyCar.GetComponent<CarController>().enabled = false;
		MyCar.GetComponent<CarUserControl>().enabled = false;
		MyCar.SetActive(true);
		CrashCube.SetActive(true);
		ViewModes.SetActive(false);
		flag = true;

		yield return new WaitForSeconds(2);
		
		this.GetComponent<BoxCollider>().enabled = true;
		MyCar.SetActive(false);
		CarController.m_Topspeed = 150.0f;
		MyCar.GetComponent<CarController>().enabled = true;
		MyCar.GetComponent<CarUserControl>().enabled = true;
		MyCar.SetActive(true);
		CrashCube.SetActive(false);
		ViewModes.SetActive(true);
		bgMusic.Play();
		flag = false;
	}

	void OnGUI() {
		if(flag == true) {
			GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 600f, 600f), "You crashed!!");
		}
	}

}
