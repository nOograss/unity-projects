using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

	public int NumeOut;
	public GameObject[] Enemies;
	public float cooldown;
	private float cd;
	// Use this for initialization
	void Start () {
		cd = cooldown * 2;
	}
	
	// Update is called once per frame
	void Update () {
	if (cd > 0) 
		{
			cd -=Time.deltaTime;
		}
		else
		{
			//z entre 2 -3
			//4 en x
			cd = cooldown;
			Vector3 pos = new Vector3(4,0.7f,Random.Range(-3,3));
			int index = Random.Range (0,Enemies.Length);
			//Instantiate(Enemies[index],pos,Quaternion.identity);
			Instantiate(Enemies[index],pos, Quaternion.Euler(0, -90, 0));
			NumeOut += 1;
		}

	}
}
