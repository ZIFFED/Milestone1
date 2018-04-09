using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	private float speed;
	Animator anim;

	// Use this for initialization
	void Start ()
	{
		speed = 2.5f;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float axisX = Input.GetAxis ("Horizontal");
		float axisY = Input.GetAxis ("Vertical");
		if (Input.GetKey ("d")) 
		{
			anim.SetTrigger ("makeRunRight");
		}
		else if (Input.GetKey ("a")) 
		{
			anim.SetTrigger ("makeRunLeft");
		}
		else
		{			
			anim.SetTrigger ("makeIdle");
		}

		transform.Translate (new Vector3 (axisX, axisY) * (speed * Time.deltaTime));
	}
}
