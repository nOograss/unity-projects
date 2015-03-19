using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public float movementspeed;
	public bool canmove;
	public Animator animation;
	// Use this for initialization
	void Start () {
		animation = GetComponent<Animator> ();
		animation.SetInteger("AnimationState",2);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canmove)
		{
			transform.Translate (-0.5f * movementspeed*Time.deltaTime,0,0);
		//	animation.SetInteger("AnimationState",2);

		}
		
	}
}