using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    // Start is called before the first frame update
    bool touch = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touch = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            touch = false;
        }
        if (touch)
        {
            transform.Translate(Vector3.up * 3000 * Time.deltaTime);
        }
    }
}
