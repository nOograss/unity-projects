using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public float movementspeed;
	public bool canmove;
	// Animation anim;
	public AnimationClip animMove;

	// Use this for initialization
	void Start () {
//		anim = gameObject.GetComponentInChildren<Animation>();
 

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canmove)
		{
 
			transform.Translate (Vector3.forward * movementspeed*Time.deltaTime);
			GetComponent<Animation>().Play(animMove.name);

			//anim.Play("walk");
		 
		}
		 
	}
}
