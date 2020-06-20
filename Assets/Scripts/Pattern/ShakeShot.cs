using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeShot : MonoBehaviour
{
    //회전되는 스피드이다.
    public float rot_Speed;
    //총알이 발사될 위치이다.
    public Transform pos;
    //발사될 총알 오브젝트이다.
    public GameObject bullet;
	public float shootingRate = 0.25f;
	private float shootCooldown;
    public float reverseRate = 3f;
    private float reverseCooldown;
    private int isReverse = 1;


	void Start () {
		shootCooldown = 0f;
        isReverse = 1;
	}

	public bool CanAttack{
		get	{
			return shootCooldown <= 0f;
		}
	}

	public bool DoReverse{
		get	{
			return reverseCooldown <= 0f;
		}
	}

    private void Update()
    {
        if (shootCooldown > 0) 	{
			shootCooldown -= Time.deltaTime;
		}
        if (reverseCooldown > 0) 	{
			reverseCooldown -= Time.deltaTime;
		}
        if (CanAttack) {
            shootCooldown = shootingRate;
            shot1();
        }
        if(DoReverse){
            reverseCooldown = reverseRate;
            isReverse *= -1;
        }
    }

    void shot1()
    {
        transform.Rotate(Vector3.forward * rot_Speed*100 * Time.deltaTime * isReverse);
        GameObject temp = Instantiate(bullet);
        temp.transform.position = transform.position;
        temp.transform.rotation = transform.rotation;
        Debug.Log(temp.transform.rotation);
    }


}
