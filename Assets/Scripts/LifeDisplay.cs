using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText.GetComponent<Text>().text= "0";
    }

    // Update is called once per frame
    void Update()
    {
        string life = "";
        GameObject temp = GameObject.Find("Player");
        int val;
        if(temp != null)
            val = temp.GetComponent<PlayerManager>().getLife();
        else
            val = 0;
        life = val.ToString();       
        Debug.Log("Life : " + life); 
        myText.GetComponent<Text>().text = life;        
    }
}
