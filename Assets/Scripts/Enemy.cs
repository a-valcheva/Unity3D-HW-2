using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Transform target;
	float posX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);

		float dist = Vector3.Distance (target.position, transform.position);
		if (dist.CompareTo (3f) < 0f) {
			// TODO to see lights on the cube when it is shooting

			//Player to feel the shooting/ to shake
			posX = Mathf.Sin(Time.deltaTime * 2f);
			target.transform.position = new Vector3(posX, target.transform.position.y, target.transform.position.z);
		}


	}
}
