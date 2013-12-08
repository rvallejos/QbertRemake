#pragma strict

function OnCollisionEnter(theCollision : Collision) { 
//	if( collision.gameObject.tag == "Plane" ) { 
//		Destroy(collision.gameObject); 
//	} 
if(theCollision.gameObject.name == "Player"){
  Debug.Log("Hit the floor");
	Debug.Log("Hit Something");
	}
}
