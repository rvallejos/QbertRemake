#pragma strict

var currentSurface:GameObject = null;
var player:GameObject;

function Start () {
	if (currentSurface != null){
		Debug.Log(player.transform.position.x);
		player.transform.position = new Vector3(currentSurface.transform.position.x,currentSurface.transform.position.y+.1,currentSurface.transform.position.z);
		Debug.Log(player.transform.position.x);
		
	}
}

function Update () {
	Debug.Log(player.transform.position.x);
}