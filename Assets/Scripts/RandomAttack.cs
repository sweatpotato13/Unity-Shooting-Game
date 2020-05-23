using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAttack : MonoBehaviour
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

    public Vector2 Rotate(Vector2 v, float degrees) {
        float sin = Mathf.Sin(degrees * Mathf.Deg2Rad);
        float cos = Mathf.Cos(degrees * Mathf.Deg2Rad);
        float tx = v.x;
        float ty = v.y;
        v.x = (cos * tx) - (sin * ty);
        v.y = (sin * tx) + (cos * ty);
        return v;
    }

}
