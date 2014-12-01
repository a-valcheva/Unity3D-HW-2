using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public Camera mainCam;
	public float looksensitivity = 5f;
	public float lookSmoothDamp = 0.1f;
	float yrotation;
	float xrotation;
	float Currentyrotation;
	float Currentxrotation;
	float yRotaionV;
	float xRotationV;
	float speed = 5f;
	
	void Update () {
		// Player moves without walking
		yrotation += Input.GetAxis ("Mouse X") * looksensitivity;
		xrotation -= Input.GetAxis ("Mouse Y") * looksensitivity;
		
		xrotation = Mathf.Clamp (xrotation, -90, 90);
		
		Currentxrotation = Mathf.SmoothDamp (Currentxrotation, xrotation, ref xRotationV, lookSmoothDamp);
		Currentyrotation = Mathf.SmoothDamp (Currentyrotation, yrotation, ref yRotaionV, lookSmoothDamp);
		
		mainCam.transform.rotation = Quaternion.Euler (xrotation, yrotation, 0);
		transform.rotation = Quaternion.Euler (0, yrotation, 0);
		
		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.Translate(Vector3.left*Time.deltaTime*speed);
		} 
		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			transform.Translate(Vector3.right*Time.deltaTime*speed);
		}
		if (Input.GetKey(KeyCode.UpArrow)) 
		{
			transform.Translate(Vector3.forward*Time.deltaTime*speed);
		}
		if (Input.GetKey(KeyCode.DownArrow)) 
		{
			transform.Translate(Vector3.back*Time.deltaTime*speed);
		}
		
	}
}﻿

