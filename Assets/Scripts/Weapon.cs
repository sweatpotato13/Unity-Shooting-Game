using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject BulletPrefab;
    public bool CanShoot = true;
    public float ShootDelay = 0.5f;
    public int BombCount = 2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Bomb", BombCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (CanShoot)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        CanShoot = false;
        Instantiate(Resources.Load ("Bullet", typeof(GameObject)), transform.position, transform.rotation);
        yield return new WaitForSeconds(ShootDelay);
        CanShoot = true;
    }
}
