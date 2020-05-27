using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombButton1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyObjects(string tag)
    {
        ParticleSystem ps = GameObject.Find("BombParticle").GetComponent<ParticleSystem>();
        ps.Play();
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject target in gameObjects)
        {
            GameObject.Destroy(target);
        }
    }
}
