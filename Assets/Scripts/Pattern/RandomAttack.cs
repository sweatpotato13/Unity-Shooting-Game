using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAttack : MonoBehaviour
{
    //총알이 발사될 위치
    public Transform pos;
    //발사될 총알 오브젝트
    public GameObject bullet;
	public float shootingRate = 0.25f;
	private float shootCooldown;
	public float rotationLimitDegree = 30.0f;

	void Start () {
		shootCooldown = 0f;
	}

	void Update () {
        if (shootCooldown > 0) 	{
			shootCooldown -= Time.deltaTime;
		}
        if (CanAttack) {
            shootCooldown = shootingRate;
            shot();
        }
	}

    void shot()
    {
    	//총알 생성
    	GameObject temp = Instantiate(bullet);
    	//총알 생성 위치를 머즐 입구로 한다.
    	temp.transform.position = pos.position;
		float seed = Time.time * 100f;
	    Random.InitState((int)seed);
		float rotationDegree = Random.Range(-(rotationLimitDegree),rotationLimitDegree);
    	temp.transform.rotation = Quaternion.Euler(0, 0, 270 + rotationDegree);
    }

	public bool CanAttack{
		get	{
			return shootCooldown <= 0f;
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
