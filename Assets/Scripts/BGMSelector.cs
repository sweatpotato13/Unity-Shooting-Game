using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("BGMSelectStart");
        switch(PlayerPrefs.GetString("stage"))
        {
          case "Button1":
            SetBGM1();
            break;
          case "Button2":
            SetBGM2();
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void SetBGM1() // Sound Manager를 이용하는 방법으로 바뀌어야함. 이 메소드는 임시방편.
    {
        Debug.Log("SetBGM1");
        SoundManager.instance.StopBGM();
        SoundManager.instance.PlaySound("yamanote");
    }

    public void SetBGM2() // Sound Manager를 이용하는 방법으로 바뀌어야함. 이 메소드는 임시방편.
    {
        Debug.Log("SetBGM2");
        SoundManager.instance.StopBGM();
        SoundManager.instance.PlaySound("Emerald_Sword");
    }
}
