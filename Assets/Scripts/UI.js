#pragma strict

var timer:float = 1.0;
var timeExp:boolean = false; 
var player:GameObject = null;

function Start () {

}

function Update () {
	if(timer < 0 ){
		timer = 0;
		timeExp = true;
	} else {
		timer +=Time.deltaTime;
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
		GUI.Label(Rect (10,30,150,30),"Tiles Touched: "+ "/20");
	}
}

function restartLevel(){
	Application.LoadLevel(Application.loadedLevel);
}