using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0.1f;
	public float jumpForce = 5f;
	//private bool isJumping = true;
	public AudioClip tone = null;
	private bool canMove = true;


	// Use this for initialization
	private void Start () {
	
	}
	
	// Update is called once per frame
	private void Update () {

		if (canMove) {

			//	Left
			if (Input.GetKeyDown (KeyCode.A)) {
				iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x",0.9613084, "z", -1.206175));
			}
			//	Right
			if (Input.GetKeyDown (KeyCode.D)) {
				iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x",0.9613084, "z", -1.206175,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
				//iTween.Stab(gameObject, iTween.Hash("delay", 1.5,"clip",tone, "pitch", 1));
			}
			//	Up
			if (Input.GetKeyDown (KeyCode.W)) {
				iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x", 1, "z", -2));
			}
			//	Down
			if (Input.GetKeyDown (KeyCode.X)) {
				transform.position += -transform.forward * speed;
			}
			//	Up-Left
			if (Input.GetKeyDown (KeyCode.Q)) {
				transform.position += -transform.forward * speed;
			}
			//	Up-Right
			if (Input.GetKeyDown (KeyCode.E)) {
				transform.position += -transform.forward * speed;
			}
			//	Down-Left
			if (Input.GetKeyDown (KeyCode.Z)) {
				transform.position += -transform.forward * speed;
			}
			//	Down-Right
			if (Input.GetKeyDown (KeyCode.C)) {
				transform.position += -transform.forward * speed;
			}

		}
	}

	private void playerCantMove(){
		canMove = false;
		Debug.Log ("Player Cant move");
	}

	private void playerCanMove(){
		canMove = true;
		Debug.Log ("Player Can move");
	}

//	private void OnCollisionEnter (Collision c)
//	{
//		if (c.gameObject.name == "Octogon" || c.gameObject.name == "Ground" || c.gameObject.name == "Square" || c.gameObject.name == "default") 
//		{
//			isJumping = false;
//		}	
//
//	}
}


