using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {
	private EnemyMove movscr;

	public float Damage;
	public float cooldown;
	private float cd;
	public AnimationClip animAttack;
	// Use this for initialization
	void Start () {
		movscr = gameObject.GetComponent<EnemyMove>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cd > 0) 
		{
			cd -=Time.deltaTime;
		}
	 
		RaycastHit hit;
		if (Physics.Raycast(transform.position, Vector3.left,out hit, 0.25f)) 
		{
		 
		//	Debug.Log(hit.transform.tag);

			if(hit.transform.tag == "Tower")
			{
				if(cd <= 0 ) 
				{
				Health hscr = hit.transform.GetComponent<Health>();

				hscr.health -= Damage;
				GetComponent<Animation>().CrossFade(animAttack.name);
				cd=cooldown;
				}
				movscr.canmove = false;
			}
		 
			else if(hit.transform.tag == "house")
			{
			//lose
				movscr.canmove = false;
				GameObject.Find("GameLogic").GetComponent<LoseGame>().lost=true;

			}
			 
		}
		else if(movscr.canmove == false)
			{
			movscr.canmove = true;
			}
 
		}
}
