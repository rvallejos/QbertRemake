using UnityEngine;
using System.Collections;

public class TestController : MonoBehaviour {
	public float movementSpeed = 5.0f;
	private int jumpHeight = 500;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("a")){
			transform.position += Vector3.right * movementSpeed * Time.deltaTime;
		}
		if(Input.GetKey("d")){
			transform.position -= Vector3.right * movementSpeed * Time.deltaTime;
		}
		if(Input.GetButtonDown("Jump")){
			//Jump ();
		}
	}

	void Jump(){
		rigidbody.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Force);
	}
}
