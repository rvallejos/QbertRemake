using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	public float speed = 0.1f;
	public float jumpForce = 5f;
	public AudioClip tone = null;
	public Surface curSurface = null;
	public int tilesTouched = 0;
	
	private bool canMove = true;
	private float maxHeight = 1.5f;
	private int diff = 0;
	
	// Use this for initialization
	private void Start () {
		if (curSurface != null) {
			gameObject.transform.position = new Vector3(curSurface.transform.position.x,curSurface.transform.position.y,curSurface.transform.position.z);	
			
		}
		//moveEnemy();
		//new Timer (moveEnemy, 0, 20000);
	}
	
	// Update is called once per frame
	private void Update () {
		moveEnemy();
		
		//			//	Left
		//			if (moveDir == 0) {
		//				nextSurface = curSurface.left;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						iTween.RotateTo(gameObject, iTween.Hash("y",90,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		//			//	Right
		//			if (moveDir == 1) {
		//				nextSurface = curSurface.right;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//						iTween.RotateTo(gameObject, iTween.Hash("y",270,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		//				//Up
		//			if (moveDir == 2) {
		//				nextSurface = curSurface.up;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//						iTween.RotateTo(gameObject, iTween.Hash("y",180,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		//			//	Down
		//			if (moveDir == 3) {
		//				nextSurface = curSurface.down;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//						iTween.RotateTo(gameObject, iTween.Hash("y",0,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		//			//Up-Left
		//			if (moveDir == 4) {
		//				nextSurface = curSurface.upleft;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//						iTween.RotateTo(gameObject, iTween.Hash("y",135,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		//				//Up-Right
		//			if (moveDir == 5) {
		//				nextSurface = curSurface.upright;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//						iTween.RotateTo(gameObject, iTween.Hash("y",225,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		//				//Down-Left
		//			if (moveDir == 6) {
		//				nextSurface = curSurface.downleft;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//						iTween.RotateTo(gameObject, iTween.Hash("y",45,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		//				//Down-Right
		//			if (moveDir == 7) {
		//				nextSurface = curSurface.downright;
		//				if(nextSurface == null){
		//					Debug.Log("Can't Go");
		//				} else {
		//					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
		//					//Debug.Log ("Height: "+jumpHeight);
		//					if(jumpHeight < maxHeight && jumpHeight > negMaxHeight){
		//						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//						iTween.RotateTo(gameObject, iTween.Hash("y",315,"oncomplete","jumpToSurface","time",.1f, "oncompleteparams",nextSurface));
		//
		//						curSurface = nextSurface;
		//					} else {
		//						Debug.Log("Too High");
		//					}
		//				}
		//			}
		
		//}
	}
	
	private void moveEnemy (){
		if (canMove) {
			//playerCantMove ();
			int moveDir = Random.Range (0, 8);
			Surface nextSurface = null;
			float negMaxHeight = maxHeight * -1;
			Debug.Log (curSurface.name);
			switch (moveDir) {
			case 0:
				nextSurface = curSurface.left;
				if (nextSurface == null) {
					Debug.Log ("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					//Debug.Log ("Height: "+jumpHeight);
					if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
						iTween.RotateTo (gameObject, iTween.Hash ("y", 90, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
						curSurface = nextSurface;
					} else {
						Debug.Log ("Too High");
					}
				}
				break;
			case 1:
				nextSurface = curSurface.right;
				if (nextSurface == null) {
					Debug.Log ("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					//Debug.Log ("Height: "+jumpHeight);
					if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						iTween.RotateTo (gameObject, iTween.Hash ("y", 270, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
						
						curSurface = nextSurface;
					} else {
						Debug.Log ("Too High");
					}
				}
				break;
			case 2:
				nextSurface = curSurface.up;
				if (nextSurface == null) {
					Debug.Log ("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					//Debug.Log ("Height: "+jumpHeight);
					if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						iTween.RotateTo (gameObject, iTween.Hash ("y", 180, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
						
						curSurface = nextSurface;
					} else {
						Debug.Log ("Too High");
					}
				}
				break;
			case 3:
				if (Input.GetKeyDown (KeyCode.X)) {
					nextSurface = curSurface.down;
					if (nextSurface == null) {
						Debug.Log ("Can't Go");
					} else {
						float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
						//Debug.Log ("Height: "+jumpHeight);
						if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
							//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
							iTween.RotateTo (gameObject, iTween.Hash ("y", 0, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
							
							curSurface = nextSurface;
						} else {
							Debug.Log ("Too High");
						}
					}
				}
				break;
			case 4:
				nextSurface = curSurface.upleft;
				if (nextSurface == null) {
					Debug.Log ("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					//Debug.Log ("Height: "+jumpHeight);
					if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						iTween.RotateTo (gameObject, iTween.Hash ("y", 135, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
						
						curSurface = nextSurface;
					} else {
						Debug.Log ("Too High");
					}
				}
				break;
			case 5:
				nextSurface = curSurface.upright;
				if (nextSurface == null) {
					Debug.Log ("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					//Debug.Log ("Height: "+jumpHeight);
					if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						iTween.RotateTo (gameObject, iTween.Hash ("y", 225, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
						
						curSurface = nextSurface;
					} else {
						Debug.Log ("Too High");
					}
				}
				break;
			case 6:
				nextSurface = curSurface.downleft;
				if (nextSurface == null) {
					Debug.Log ("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					//Debug.Log ("Height: "+jumpHeight);
					if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						iTween.RotateTo (gameObject, iTween.Hash ("y", 45, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
						
						curSurface = nextSurface;
					} else {
						Debug.Log ("Too High");
					}
				}
				break;
			case 7:
				nextSurface = curSurface.downright;
				if (nextSurface == null) {
					Debug.Log ("Can't Go");
				} else {
					float jumpHeight = nextSurface.transform.position.y - curSurface.transform.position.y;
					//Debug.Log ("Height: "+jumpHeight);
					if (jumpHeight < maxHeight && jumpHeight > negMaxHeight) {
						//iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
						iTween.RotateTo (gameObject, iTween.Hash ("y", 315, "oncomplete", "jumpToSurface", "time", .1f, "oncompleteparams", nextSurface));
						
						curSurface = nextSurface;
					} else {
						Debug.Log ("Too High");
					}
				}
				break;
			default:
				break;
				
			}
			Debug.Log (canMove);	
		}
	}
	
	private void jumpToSurface(Surface nextSurface){
		iTween.MoveTo(gameObject, iTween.Hash("y" , nextSurface.transform.position.y+.75, "x",nextSurface.transform.position.x, "z", nextSurface.transform.position.z,"onstart","playerCantMove", "oncomplete", "playerCanMove"));
		//curSurface.touch = true;
	}
	
	private void playerCantMove(){
		canMove = false;
	}
	
	private void playerCanMove(){
		canMove = true;
	}
}