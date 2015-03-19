using UnityEngine;
using System.Collections;

public class Allies : MonoBehaviour {
	public Animator animation;
	public float cooldown;
 
	public GameObject projectile;

	private float cd;
	// Use this for initialization
	void Start () {
		animation = GetComponent<Animator> ();
		animation.SetInteger("AnimationState",0);
	}
	
	// Update is called once per frame
	void Update () {
		if (cd > 0) 
		{
			cd -=Time.deltaTime;
		}
		RaycastHit2D hit;
		Vector2 lcc = new Vector2(transform.position.x + 20f ,transform.position.y);
		if (hit = Physics2D.Raycast (transform.position, lcc, 20f, 1 << LayerMask.NameToLayer ("Tile"))) {
				 
						print (hit.transform.tag);
						if (hit.transform.tag == "Enemy") {
								if (cd <= 0) {
										animation.SetInteger ("AnimationState", 1);
					Instantiate(projectile,transform.position,Quaternion.identity);
								}
						}  

				} else {
			animation.SetInteger ("AnimationState", 0);		
				}
	}
}
