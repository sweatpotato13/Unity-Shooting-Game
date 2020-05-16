using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject BulletPrefab;
    public bool CanShoot = true;
    public float ShootDelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

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
        Instantiate(BulletPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(ShootDelay);
        CanShoot = true;
    }
}
