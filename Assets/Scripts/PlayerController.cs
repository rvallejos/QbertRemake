using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0.1f;
	public float jumpForce = 5f;
	private bool isJumping = true;
	public AudioClip tone = null;


	// Use this for initialization
	private void Start () {
	
	}
	
	// Update is called once per frame
	private void Update () {

		//	Right-Jump

		if (Input.GetKeyDown (KeyCode.D)) {
			iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x",0.9613084, "z", -1.206175));
			iTween.Stab(gameObject, iTween.Hash("delay", 1.5,"clip",tone, "pitch", 1));
		}

		if (!isJumping) {	
			if (Input.GetKeyDown (KeyCode.D)){
				transform.rigidbody.AddForce (0, jumpForce, 0);
				isJumping = true;
			}
		}


		//	Left-Jump

		if (Input.GetKeyDown (KeyCode.A)) {
			iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x",0.9613084, "z", -1.206175));
		}

		if (!isJumping) {

			if (Input.GetKeyDown (KeyCode.A)) {
				transform.rigidbody.AddForce (0, jumpForce, 0);
				isJumping = true;
			}
		
		}

		//	Forward-Jump

		if (Input.GetKeyDown (KeyCode.W)) {
			iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x", 1, "z", -2));
		}

		if (!isJumping) {

			if (Input.GetKeyDown (KeyCode.W)) {
				transform.rigidbody.AddForce (0, jumpForce, 0);
				isJumping = true;
			}
		}
		//	Backward-Jump

		if (Input.GetKeyDown (KeyCode.X)) {
			transform.position += -transform.forward * speed;
		}

		if (!isJumping) {

				if (Input.GetKeyDown (KeyCode.X)) {
					transform.rigidbody.AddForce (0, jumpForce, 0);
					isJumping = true;
				}
			}

	}


	private void OnCollisionEnter (Collision c)
	{
		if (c.gameObject.name == "Octogon" || c.gameObject.name == "Ground" || c.gameObject.name == "Square" || c.gameObject.name == "default") 
		{
			isJumping = false;
		}	

	}
}


