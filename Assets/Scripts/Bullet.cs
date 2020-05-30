using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    bool seen = false;
    public float speed = 100f;
    public Rigidbody2D rb;
    //회전될 오브젝트이다. -> 자기 자신
    public Transform center;

    //바라볼 물체이다. - > 보스
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * speed;
        var rot = target.position - center.position;
        //x,y의 값을 조합하여 Z방향 값으로 변형함. -> ~도 단위로 변형
        var angle = Mathf.Atan2(rot.y, rot.x) * Mathf.Rad2Deg;
        //해당 타겟 방향으로 회전한다.
        center.rotation = Quaternion.Euler(0, 0, angle-90);
        
        if (GetComponent<Renderer>().isVisible)
            seen = true;
        if (seen && !GetComponent<Renderer>().isVisible)
            Destroy(gameObject);
        
    }
}
