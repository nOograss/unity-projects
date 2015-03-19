using UnityEngine;
using System.Collections;

public class IncomeIncrease : MonoBehaviour {
 
	public float cooldown;
	private float cd;
	private Money mscr;
	public float income;

	// Use this for initialization
	void Start () {
		cd = cooldown  ;
		mscr = GameObject.Find("GameLogic").GetComponent<Money>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cd > 0) 
		{
			cd -=Time.deltaTime;

		}
		else
		{
			cd=cooldown;
			mscr.money +=  income;
		}
		
	}
}
