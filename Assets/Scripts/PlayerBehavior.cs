using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	public float speed;
	public GameObject shotSpawn;
	public GameObject shot;

	private Rigidbody rb;

	public float fireRate;
	private float nextFire;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + nextFire;
			Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);
		}
	}

	void FixedUpdate () {
		float moveHorizonal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizonal, 0.0f, moveVertical);
		rb.AddForce(movement * speed);
	}
}


