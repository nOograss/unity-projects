using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float movementspeed;
	public float Damage;
	private Vector3 initpos;
	public GameObject explosion;
	// Use this for initialization
	void Start () {
		initpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * movementspeed*Time.deltaTime);
		//hors ecran
		if(Vector3.Distance(transform.position,initpos)> 20 )
		{
		Destroy(gameObject);

		}
	}

	void OnTriggerEnter(Collider col) 
	{
		if (col.tag == "Enemies") 
		{
			col.GetComponent<Health>().health -=Damage;
 
	 		Destroy(gameObject);

		}
	}
}
