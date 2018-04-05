//Help recieved from https://answers.unity.com/questions/975602/how-to-move-a-2d-sprite.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	private float speed;

	// Use this for initialization
	void Start () {
		speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
		float axisX = Input.GetAxis ("Horizontal");
		float axisY = Input.GetAxis ("Vertical");

		transform.Translate(new Vector3(axisX, axisY) * (speed * Time.deltaTime));
	}
}
