#pragma strict

var player : Transform;

var accumColor : float = 0;

var increment : float = 0.03;
var decrement : float = 0.00005;
var radius : float = 3;
var counter : int = 0;
var startColor : Color = Color(0, 1.0, 1.0,1);

var timer:float = 30.0;
var timeExp:boolean = false;

var up:GameObject = null;
var down:GameObject = null;
var left:GameObject = null;
var right:GameObject = null;
var upleft:GameObject = null;
var upright:GameObject = null;
var downleft:GameObject = null;
var downright:GameObject = null;

function Start () {

}

function OnCollisionEnter(collision:Collision){
    if( collision.gameObject.tag == "player" ){
        Destroy(collision.gameObject);
    }
}

function Update () {

	if(timer <= 0){
		timer = 0;
		timeExp = true;
	} else {
		timer -=Time.deltaTime;
	}

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
	if(counter >= 21) {
		//Do Something Here
		GUI.Label(Rect (10,10,150,30),"You Win!");
		if (GUI.Button (Rect (20,40,80,20), "Restart")) {
			restartLevel();
		}
	
	}

}


function OnGUI(){
	if(timeExp){
		//Do Something Here
		GUI.Label(Rect (10,10,150,30),"Time's Up! You lose!");
		if (GUI.Button (Rect (20,40,80,20), "Restart")) {
			restartLevel();
		}
	} else {
		GUI.Label(Rect (10,10,100,30),"Time Left: " + timer.ToString("0")+"s");
	}
}

function restartLevel(){
	Application.LoadLevel(Application.loadedLevel);
}