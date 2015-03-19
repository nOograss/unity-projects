using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	public bool isTower;
	public bool isDead;
	private Health hscr;
	private Money mscr;
	private EnemyStatistic escr;
	private EnemyMove emscr;
	//Animation anim;
	public AnimationClip animDie;
	public bool deathstatus;
 
	// Use this for initialization
	void Start () {
		hscr = gameObject.GetComponent<Health> ();
		mscr = GameObject.Find("GameLogic").GetComponent<Money>();
		if (!isTower) {
			escr = gameObject.GetComponent<EnemyStatistic>();
			emscr = gameObject.GetComponent<EnemyMove>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		 
	 
	if (hscr.health <= 0) 
		{ 
			if(isTower)
			{
				Destroy(gameObject);

			}
			else
			{
				 
				//donne des ressources au joueur
				if(!deathstatus) 
				{
				mscr.money += escr.Worth;
				deathstatus=true;
				}
				emscr.canmove=false;
				Destroy(gameObject,animDie.length); 
				GetComponent<Animation>().CrossFade(animDie.name);
				 

			}
		}
	}
}
