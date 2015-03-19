using UnityEngine;
using System.Collections;

public class SetTower : MonoBehaviour {
	public int Selected;
	public GameObject[] Tower;
	public int[] prices;
	public GameObject Tile;
	private Money mscr;
	//private TileTaken tscr;
	//private Vector3 pos;
	// Use this for initialization
	void Start () {
		//mscr = GameObject.Find ("GameLogic").GetComponents();
		mscr = GameObject.Find("GameLogic").GetComponent<Money>();
 
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log(Input.mousePosition);

		if(Input.GetMouseButtonDown(0)  ) 
		{

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit,20));
			{
				if(hit.transform.tag == "Tile") 
				{
					Tile = hit.transform.gameObject;
				}
				else
				{
					Tile = null;
				}
			}
			if(Tile !=null) { 


			TileTaken tscr = Tile.gameObject.GetComponent<TileTaken>();
			if(!tscr.isTaken && mscr.money>=prices[Selected])
			{
				mscr.money -= prices[Selected];
				Vector3 pos= new Vector3(Tile.transform.position.x,1F,Tile.transform.position.z);
				tscr.isTaken = true;
				tscr.Tower = (GameObject)Instantiate(Tower[Selected],pos,Quaternion.identity);
			}

		}


		}
	}
}
