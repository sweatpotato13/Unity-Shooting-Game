using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//자동으로 AudioSource GetComponent 부착
[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
//어디서나 접근할수 있는 정적 변수를 만듬니다
    public static SoundManager instance;

    public AudioSource myAudio = null;

    public AudioClip sndClickButton;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void PlayClickButton()
    {
        myAudio.PlayOneShot(sndClickButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

