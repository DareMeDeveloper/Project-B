using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntMovement : MonoBehaviour {
	public Rigidbody rb;
	public int rm = 25;
	public int lm = 25;
	public float turnspeed;
	public bool R90 = false;
	public bool l90 = true;
	// Use this for initialization
	void Start () {
	}

	void FixedUpdate () {
		if(Input.GetKey ("d")){
			rb.AddForce (rm, 0, 0 * Time.deltaTime);
		}
		if(Input.GetKey ("a")){
			rb.AddForce (-lm, 0,0  * Time.deltaTime);
			}
		}
	}