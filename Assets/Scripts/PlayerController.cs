using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0.1f;
	public float jumpForce = 5f;
	public AudioClip tone = null;
	public Surface curSurface = null;

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
				Surface nextSurface = curSurface.left;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}
			//	Right
			if (Input.GetKeyDown (KeyCode.D)) {
				Surface nextSurface = curSurface.right;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}
			//	Up
			if (Input.GetKeyDown (KeyCode.W)) {
				Surface nextSurface = curSurface.up;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}
			//	Down
			if (Input.GetKeyDown (KeyCode.X)) {
				Surface nextSurface = curSurface.down;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}
			//	Up-Left
			if (Input.GetKeyDown (KeyCode.Q)) {
				Surface nextSurface = curSurface.upleft;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}
			//	Up-Right
			if (Input.GetKeyDown (KeyCode.E)) {
				Surface nextSurface = curSurface.upright;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}
			//	Down-Left
			if (Input.GetKeyDown (KeyCode.Z)) {
				Surface nextSurface = curSurface.downleft;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}
			//	Down-Right
			if (Input.GetKeyDown (KeyCode.C)) {
				Surface nextSurface = curSurface.downright;
				if(nextSurface == null){
					Debug.Log("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					Debug.Log ("Height: "+jumpHeight);
					if(jumpHeight < maxHeight){
						iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						curSurface = nextSurface;
					} else {
						Debug.Log("Too High");
					}
				}
			}

		}
	}

	private void playerCantMove(){
		canMove = false;
	}

	private void playerCanMove(){
		canMove = true;
	}
}