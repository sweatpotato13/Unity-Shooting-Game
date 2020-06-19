using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadShot : MonoBehaviour
{
    
    //총알이 발사될 위치
    public Transform pos;
    public GameObject bullet;
	public float shootingRate = 0.25f;
	private float shootCooldown;

	void Start () {
		shootCooldown = 0f;
	}

	public bool CanAttack{
		get	{
			return shootCooldown <= 0f;
		}
	}

    private void Update()
    {
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
        //360번 반복
        for (int i = 245; i < 295; i += 5)
        {
            //총알 생성
            GameObject temp = Instantiate(bullet);

            //총알 생성 위치를 머즐 입구로 한다.
            temp.transform.position = pos.position;

            //Z에 값이 변해야 회전이 이루어지므로, Z에 i를 대입한다.
            temp.transform.rotation = Quaternion.Euler(0, 0, i);
        }
    }
}
