using UnityEngine;
using System.Collections;

public class MoneyLabel : MonoBehaviour {

	public UILabel label;
	public Money mscr;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		label.text = "Money: " + mscr.money;
	}
}
