using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public float cooldown;
	private float cd;
	public GameObject projectile;
	public bool hasenemy;
	// Use this for initialization
	void Start () {
		cd = cooldown;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (cd);
		if (cd > 0) 
		{
			cd -=Time.deltaTime;
		} 
		 
		RaycastHit hit;
		if(Physics.Raycast(transform.position,Vector3.right, out hit,15))
		{
			//Debug.Log (hit.transform.tag);
			if(hit.transform.tag=="Enemies"  )
			{
				if(cd <=0)
				{
					cd=cooldown;
					Instantiate(projectile,transform.position,Quaternion.identity);
				} 
				hasenemy=true;
		 
		 
			}
			//on regarde en chaine si la tour devant nous a un ennemi.
			else if(hit.transform.tag =="Tower")
			{
				Shoot scr=hit.transform.gameObject.GetComponent<Shoot>();
				if(scr.hasenemy) 
				{
					hasenemy=true;
				}
			}
			else
			{
				hasenemy=false;
			}

		}
		if (hasenemy) 
		{	
			if(cd <=0)
			{
				cd=cooldown;
				Instantiate(projectile,transform.position,Quaternion.identity);
			} 
		}
		 
	}
}
