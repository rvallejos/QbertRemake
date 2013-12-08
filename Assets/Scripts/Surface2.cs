using UnityEngine;
using System.Collections;

public class Surface2 : MonoBehaviour {


	private float accumColor = 0f;
	
	private float increment = 0.03f;
	private float decrement = 0.00005f;
	private float radius = 3f;
	private int counter = 0;
	private Color startColor = new Color(0f, 1.0f, 1.0f,1f);
	
	private float timer = 30.0f;
	private bool timeExp = false;
	
	public Surface2 up = null;
	public Surface2 down = null;
	public Surface2 left = null;
	public Surface2 right = null;
	public Surface2 upleft = null;
	public Surface2 upright = null;
	public Surface2 downleft = null;
	public Surface2 downright = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
