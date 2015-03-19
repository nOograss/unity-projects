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
		transform.Translate (Vector2.right * movementspeed*Time.deltaTime);
		//hors ecran
		if(Vector2.Distance(transform.position,initpos)> 10 )
		{
			Destroy(gameObject);
			
		}
	}
	
	void OnTriggerEnter2D(Collider2D col) 
	{
		if (col.tag == "Enemy") 
		{
			col.GetComponent<Health>().health -=Damage;
			Destroy(gameObject);
			
		}
	}
}
