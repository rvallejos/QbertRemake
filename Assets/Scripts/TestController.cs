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
		if(Input.GetKey("a")||Input.GetKey(KeyCode.Keypad4)){
			transform.position += Vector3.right * movementSpeed * Time.deltaTime;
		}
		if(Input.GetKey("d")||Input.GetKey(KeyCode.Keypad6)){
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
