using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public SimpleHealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.UpdateBar(100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject temp = GameObject.Find("Enemy");
        float val;
        if(temp != null)
            val = temp.GetComponent<Health>().getHprate();
        else
            val = 0;
        healthBar.UpdateBar( val, 100 );
    }
}
