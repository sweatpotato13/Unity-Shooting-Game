using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
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
        string score = "";
        GameObject temp = GameObject.Find("Player");
        int val;
        if(temp != null)
            val = temp.GetComponent<PlayerManager>().getScore();
        else
            val = 0;
        score = val.ToString();        
        myText.GetComponent<Text>().text=score;
    }
}
