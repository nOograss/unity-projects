using UnityEngine;
using System.Collections;

public class TowerButton : MonoBehaviour {

	public int Index;
	public SetTower setscr;
	// Use this for initialization
	void Start () {
	
	}
  
	void OnClick() 
	{
		setscr.Selected = Index;
	}

}
