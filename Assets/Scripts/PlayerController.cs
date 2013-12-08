using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0.1f;
	public float jumpForce = 5f;
	public AudioClip tone = null;
	public Surface2 curSurface = null;

	private bool canMove = true;
	private float maxHeight = 1.5f;


	// Use this for initialization
	private void Start () {
		if (curSurface != null) {
			gameObject.transform.position = new Vector3(curSurface.transform.position.x,curSurface.transform.position.y,curSurface.transform.position.z);	
		}
	}
	
	// Update is called once per frame
	private void Update () {

		if (canMove) {

			//	Left
			if (Input.GetKeyDown (KeyCode.A)) {
//				iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x",0.9613084, "z", -1.206175));
				Surface2 nextSurface = curSurface.left;
				
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", -1.206175,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}

				}
			}
			//	Right
			if (Input.GetKeyDown (KeyCode.D)) {
				Surface2 nextSurface = curSurface.right;
				
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", -1.206175,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
					curSurface = nextSurface;
					Debug.Log ("Height: "+jumpHeight);
				}

			}
			//	Up
			if (Input.GetKeyDown (KeyCode.W)) {
				//iTween.MoveTo(gameObject, iTween.Hash("y" , 5, "x", 1, "z", -2));
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
}