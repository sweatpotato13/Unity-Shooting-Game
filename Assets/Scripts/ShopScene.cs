﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ShopScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMainScene()
    {
        SoundManager.instance.PlaySound("ButtonClick");
        SceneManager.LoadScene("MainScene");
    }
}
