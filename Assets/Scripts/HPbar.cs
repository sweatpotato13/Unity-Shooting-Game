using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public Slider mainSlider;

    // Start is called before the first frame update
    void Start()
    {
        mainSlider.value = 100;
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
        Debug.Log(val);
        mainSlider.value = val;
    }
}
