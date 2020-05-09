using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSelector : MonoBehaviour
{
    Image myImageComponent;
    public Sprite myFirstImage; //Drag your first sprite here in inspector.
    public Sprite mySecondImage; //Drag your second sprite here in inspector.
    //public myBGM;

    void Start() //Lets start by getting a reference to our image component.
    {
        myImageComponent = GetComponent<Image>(); //Our image component is the one attached to this gameObject.

        switch(PlayerPrefs.GetString("stage"))
        {
          case "Button1":
            SetImage1();
            break;
          case "Button2":
            SetImage2();
            break;
        }

    }

    void Update()
    {

    }

    public void SetImage1() //method to set our first image
    {
        myImageComponent.sprite = myFirstImage;
    }

    public void SetImage2()
    {
        myImageComponent.sprite = mySecondImage;
    }



}
