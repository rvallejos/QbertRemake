#pragma strict

var player : Transform;

var accumColor : float = 0;

var increment : float = 0.03;
var decrement : float = 0;
var radius : float = 3;

function Start () {

}

function OnCollisionEnter(collision:Collision)
{
    if( collision.gameObject.tag == "construction_worker" )
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
	
	
	var myColor : Color = Color(0,accumColor + .5,accumColor - .75,1);
	renderer.material.color = myColor;
	
	 

}