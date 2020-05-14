using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public int damage = 1;
	public bool isEnemyShot = false;
    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject, 20); //20초 삭제
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
