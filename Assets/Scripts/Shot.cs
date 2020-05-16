using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public int damage = 1;
	public bool isEnemyShot = false;
    public bool seen;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Renderer>().isVisible)
          seen = true;

        if (seen && !GetComponent<Renderer>().isVisible)
          Destroy(gameObject);
        
    }
}
