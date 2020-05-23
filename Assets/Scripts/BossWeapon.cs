using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    public Transform shotPrefab;
	public float shootingRate = 0.25f;
	public float rotationLimitDegree = 30.0f;
	private float shootCooldown;
	private GameObject playerObj;
  
	void Start () {
		shootCooldown = 0f;
		playerObj = GameObject.FindGameObjectWithTag("Player");
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
	public void RandomAttack(bool isEnemy){
		if (CanAttack) {
			shootCooldown = shootingRate;

			Transform shotTransform = Instantiate (shotPrefab) as Transform;
			shotTransform.position = transform.position;

			Shot tempShot = shotTransform.gameObject.GetComponent<Shot> ();
			if (tempShot != null) {
				tempShot.isEnemyShot = isEnemy;
			}

			Move tempMove = shotTransform.gameObject.GetComponent<Move> ();
			if (tempMove != null) {
				tempMove.direction = new Vector2(0,-1);//transform.up;
				float temp = Time.time * 100f;
        		Random.InitState((int)temp);
				float rotationDegree = Random.Range(-(rotationLimitDegree),rotationLimitDegree);
				tempMove.direction = Rotate(tempMove.direction, rotationDegree);
			}
		}
	}

	public void RandomAimingAttack(bool isEnemy){
		if (CanAttack) {
			shootCooldown = shootingRate;

			Transform shotTransform = Instantiate (shotPrefab) as Transform;
			shotTransform.position = transform.position;

			Shot tempShot = shotTransform.gameObject.GetComponent<Shot> ();
			if (tempShot != null) {
				tempShot.isEnemyShot = isEnemy;
			}

			Move tempMove = shotTransform.gameObject.GetComponent<Move> ();
			if (tempMove != null) {
				tempMove.direction = new Vector2(0,-1);//transform.up;
				Vector2 playerPosition = playerObj.transform.position;
				float Angle = AngleTo(playerPosition, shotTransform.position);
				//Debug.Log("Player = " + playerPosition);
				//Debug.Log("shot = " + shotTransform.position);
				//Debug.Log("Angle = " + Angle);
				float temp = Time.time * 100f;
        		Random.InitState((int)temp);
				float rotationDegree = Random.Range(Angle-10,Angle+10);
				tempMove.direction = Rotate(tempMove.direction, rotationDegree);
			}
		}
	}

    public Vector2 Rotate(Vector2 v, float degrees) {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);
        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v;
    }

	public float AngleTo(Vector2 this_, Vector2 to)
     {
         Vector2 direction = to - this_;
         float angle = Mathf.Atan2(direction.y,  direction.x) * Mathf.Rad2Deg;
         angle = angle - 90.0f;
         return angle;
     }
}
