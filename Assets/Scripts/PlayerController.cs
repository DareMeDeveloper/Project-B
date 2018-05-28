using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class PlayerController : MonoBehaviour {

    

    public float speed = 5;

	private Rigidbody rb;

	public LayerMask groundLayers;

	public float jumpforce = 7;

	public SphereCollider col;

    void Start () {
        rb = GetComponent<Rigidbody>();
		col = GetComponent<SphereCollider>();
    }

	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);

		if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce (Vector3.up * jumpforce, ForceMode.Impulse);
		}
	}
	private bool IsGrounded(){
		return Physics.CheckCapsule(col.bounds.center, new Vector3
			(col.bounds.min.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
	}

}
