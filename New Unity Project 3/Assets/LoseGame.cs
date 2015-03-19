using UnityEngine;
using System.Collections;

public class LoseGame : MonoBehaviour {

	public bool lost;
	private Money mscr;
	private float initmoney;
	private WaveManager wavscr;
	// Use this for initialization
	void Start () 
	{
 
		mscr = gameObject.GetComponent<Money>();
		wavscr = gameObject.GetComponent<WaveManager> ();
		initmoney=mscr.money;

	}
	
	// Update is called once per frame
	void Update () {
		if (lost) 
		{
			//reset tous les gameobject y compris les tiles tiletaken
			lost = false;
			GameObject[] towers = GameObject.FindGameObjectsWithTag ("Tower");
			for (int i=1; i<towers.Length; i++) {
					Destroy (towers [i]);
			}
			mscr.money = initmoney;
		}
	}
}
