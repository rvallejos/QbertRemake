#pragma strict

var player : Transform;

var accumColor : float = 0;

var increment : float = 0.03;
var decrement : float = 0.00005;
var radius : float = 3;
var counter : int = 0;
var startColor : Color = Color(0, 1.0, 1.0,1);
function Start () {

}

function OnCollisionEnter(collision:Collision)
{
    if( collision.gameObject.tag == "player" )
    {
        Destroy(collision.gameObject);
    }
}

function Update () {

	var dist : float = Vector3.Distance(this.transform.position, player.position);

	if (dist < radius) {

		accumColor += increment;
		}else{
		accumColor -= decrement;
	}

	if (accumColor > 1){
		
		accumColor = 1;
	
	}

	if (accumColor < 0){
		
		accumColor = 0;
	}
	
	
	var myColor : Color = Color(0,accumColor, accumColor,1); //accumColor + .5 accumColor - .75
	renderer.material.color = myColor;
	if(startColor==myColor){
		counter++;
	}
//	else{
//		counter--;
//	}
	if(counter >= 21) Debug.Log("You Won!");
	//if(counter < 21) 
	else Debug.Log("Keep going");

}