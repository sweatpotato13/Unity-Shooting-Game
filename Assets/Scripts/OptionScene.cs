using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class OptionScene : MonoBehaviour
{
    public Slider bgmVolume = null;
    public Slider sfxVolume = null;

    private float bgmVol = 1f;
    private float sfxVol = 1f;

    // Start is called before the first frame update
    void Start()
    {
        bgmVol = PlayerPrefs.GetFloat("bgmVol",1f);
        bgmVolume.value = bgmVol;
        SoundManager.instance.SetVolumeBGM(bgmVolume.value);

        sfxVol = PlayerPrefs.GetFloat("sfxVol",1f);
        bgmVolume.value = sfxVol;
        SoundManager.instance.SetVolumeSFX(sfxVolume.value);
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        SoundManager.instance.SetVolumeBGM(bgmVolume.value);
        bgmVol = bgmVolume.value;
        PlayerPrefs.SetFloat("bgmVol",bgmVol);
        SoundManager.instance.SetVolumeSFX(sfxVolume.value);
        sfxVol = sfxVolume.value;
        PlayerPrefs.SetFloat("sfxVol",sfxVol);
    }

    public void ChangeMainScene()
    {
        SoundManager.instance.PlaySound("ButtonClick");
        SceneManager.LoadScene("MainScene");
    }
}
