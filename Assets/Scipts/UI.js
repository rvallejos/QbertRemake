#pragma strict

var timer:float = 60.0;
var timeExp:boolean = false;

function Start () {

}

function Update () {
	if(timer <= 0){
		timer = 0;
		timeExp = true;
		restartLevel();
	} else {
		timer -=Time.deltaTime;
	}
}

function OnGUI(){
	if(timeExp){
		//Do Something Here
		GUI.Label(Rect (10,10,150,30),"Time's Up! You lose!");
	} else {
		GUI.Label(Rect (10,10,100,30),"Time Left: " + timer.ToString("0")+"s");
	}
}

function restartLevel(){
	yield WaitForSeconds (2);
	Application.LoadLevel(Application.loadedLevel);
}