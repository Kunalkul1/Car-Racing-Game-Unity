﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRotateScript : MonoBehaviour {

	// Use this for initialization
	void Update () {
		transform.Rotate (0, 1, 0, Space.World);
	}
}
