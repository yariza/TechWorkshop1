using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	[SerializeField, Range(0, 10)]
	float speed = 1f;

	// Bonus: Acceleration?
	// Bonus: Implement jumping using Input.GetKeyDown(KeyCode.Space)

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// float horizontal = Input.GetAxis("Horizontal") * speed;
		// float vertical = Input.GetAxis("Vertical") * speed;
		// transform.position = transform.position + new Vector3(horizontal * Time.deltaTime, 0f, vertical * Time.deltaTime);

		// clamp magnitude to 1 so that we don't walk faster when moving diagonally
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontal, 0f, vertical);
		movement = Vector3.ClampMagnitude(movement, 1.0f);
		transform.position = transform.position + movement * speed * Time.deltaTime;
	}
}
