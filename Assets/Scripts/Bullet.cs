using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    bool seen = false;
    public float speed = 300f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      rb.velocity = transform.up * speed;

      if (GetComponent<Renderer>().isVisible)
          seen = true;

      if (seen && !GetComponent<Renderer>().isVisible)
          Destroy(gameObject);

    }
}
