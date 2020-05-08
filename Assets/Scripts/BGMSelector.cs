using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSelector : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip BGM1;
    public AudioClip BGM2;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
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
        if (Input.GetMouseButtonDown(0))
        {
          if (AudioSource.clip == BGM1)
              SetBGM2();
          else
              SetBGM1();
        }
    }

    public void SetBGM1() // Sound Manager를 이용하는 방법으로 바뀌어야함. 이 메소드는 임시방편.
    {
        AudioSource.clip = BGM1;
        AudioSource.Play();
    }

    public void SetBGM2() // Sound Manager를 이용하는 방법으로 바뀌어야함. 이 메소드는 임시방편.
    {
        AudioSource.clip = BGM2;
        AudioSource.Play();
    }
}
