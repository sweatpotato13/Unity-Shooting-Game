using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp = 1;
	public bool isEnemy = true;

	public void Damage(int value){
		hp = hp - value;
		if (hp <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		Shot tempShot = other.gameObject.GetComponent<Shot> ();
		if (tempShot != null) {
			if (tempShot.isEnemyShot != isEnemy) {
				Damage (tempShot.damage);
				Destroy (tempShot.gameObject);
			}
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
