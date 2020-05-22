using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private BossWeapon[] myWeapons;

	void Awake(){
		myWeapons = GetComponentsInChildren<BossWeapon> ();
	}
		
	void Update () {
		for (int i = 0; i < myWeapons.Length; i++) {
			if (myWeapons[i] != null && myWeapons[i].CanAttack) {
				myWeapons[i].RandomAttack (true);
			}	
		}

	}
}
