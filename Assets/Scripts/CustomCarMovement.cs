using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CustomCarMovement : MonoBehaviour {

	public CarUserControl carUsrCtrl;

	void Start () {

		carUsrCtrl = GetComponent<CarUserControl>();
	}
	
	void Update () {



		if (Input.GetKeyDown(KeyCode.E))
		{
			transform.Rotate(0, 90, 0);
		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			transform.Rotate(0, -90, 0);
		}

		if (Input.GetKeyDown(KeyCode.F))
		{
			carUsrCtrl.startMovingForward = true;
		}

	}


	void OnStartMoving()
	{
		carUsrCtrl.startMovingForward = true;
	}
}
