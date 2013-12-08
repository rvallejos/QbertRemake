using UnityEngine;
using System.Collections;

public class GUIMaker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject GUIObject = GameObject.FindGameObjectWithTag("GUI");
		if(GUIObject == null){
			GameObject newGUI = new GameObject();
			newGUI.AddComponent<GUISystem>();
			newGUI.name = "GUI";
			newGUI.tag = "GUI";
		}
	}

}
