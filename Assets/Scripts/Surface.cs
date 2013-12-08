using UnityEngine;
using System.Collections;

public class Surface : MonoBehaviour {


	private float accumColor = 0f;
	
	private float increment = 0.03f;
	private float decrement = 0.00005f;
	private float radius = 3f;
	private int counter = 0;
	private Color startColor = new Color(0f, 1.0f, 1.0f,1f);
	
	private float timer = 30.0f;
	private bool timeExp = false;
	
	public Surface up = null;
	public Surface down = null;
	public Surface left = null;
	public Surface right = null;
	public Surface upleft = null;
	public Surface upright = null;
	public Surface downleft = null;
	public Surface downright = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

}
