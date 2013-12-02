#pragma strict

var player : Transform;

var accumColor : float = 0;

function Start () {

}

function Update () {

	var dist : float = Vector3.Distance(this.transform.position, player.position);

		if (dist < 3) {

			accumColor += 0.03;
			}else{
			accumColor -= 0.01;
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