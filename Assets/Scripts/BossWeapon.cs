using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform shotPrefab;
	public float shootingRate = 0.25f;

	private float shootCooldown;

	void Start () {
		shootCooldown = 0f;
	}
	
	void Update () {
		if (shootCooldown > 0) 	{
			shootCooldown -= Time.deltaTime;
		}
	}

	public bool CanAttack{
		get	{
			return shootCooldown <= 0f;
		}
	}

	public void Attack(bool isEnemy){
		if (CanAttack) {
			shootCooldown = shootingRate;

			Transform shotTransform = Instantiate (shotPrefab) as Transform;
			shotTransform.position = transform.position;

			Shot tempShot = shotTransform.gameObject.GetComponent<Shot> ();
			if (tempShot != null) {
				tempShot.isEnemyShot = isEnemy;
			}
			
			Move[] tempMove = new Move[10];
			for(int i = 0;i<10;i++){
				tempMove[i] = shotTransform.gameObject.GetComponent<Move> ();
				tempMove[i].direction = new Vector3(-Mathf.Cos(Mathf.PI/4 * (i*2)/7) , -Mathf.Sin(Mathf.PI/4 * (i*2)/7),0);
			}
		}
	}
}
