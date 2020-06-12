using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class OptionScene : MonoBehaviour
{
    public Slider bgmVolume;
    public Slider sfxVolume;

    private float bgmVol = 1f;
    private float sfxVol = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Load();
        bgmVolume.value = bgmVol;
        SoundManager.instance.SetVolumeBGM(bgmVolume.value);

        sfxVolume.value = sfxVol;
        SoundManager.instance.SetVolumeSFX(sfxVolume.value);
    }

    // Update is called once per frame
    void Update()
    {
        SoundSlider();
    }

    public void Load(){
        if(PlayerPrefs.HasKey("bgmVol")){
            bgmVol = PlayerPrefs.GetFloat("bgmVol");
            Debug.Log("bgmVol Loaded" + bgmVol);
        }
        if(PlayerPrefs.HasKey("sfxVol")){
            sfxVol = PlayerPrefs.GetFloat("sfxVol");
            Debug.Log("sfxVol Loaded" + sfxVol);
        }
    }

    public void Reset(){
        bgmVolume.value = 1f;
        sfxVolume.value = 1f;
        Save();
    }

    public void Save(){
        SoundManager.instance.SetVolumeBGM(bgmVolume.value);
        SoundManager.instance.SetVolumeSFX(sfxVolume.value);
        PlayerPrefs.SetFloat("bgmVol", bgmVol);
        PlayerPrefs.SetFloat("sfxVol", sfxVol);
        Debug.Log("bgmVol Saved" + bgmVol);
        Debug.Log("sfxVol Saved" + sfxVol);
    }

    public void SoundSlider()
    {
        bgmVol = bgmVolume.value;
        sfxVol = sfxVolume.value;
        Debug.Log("bgmVol Updated" + bgmVol);
        Debug.Log("sfxVol Updated" + sfxVol);
    }

    public void Back()
    {
        SoundManager.instance.PlaySound("ButtonClick");
        SceneManager.LoadScene("MainScene");
    }

    public void Apply()
    {
        Save();
        SoundManager.instance.PlaySound("ButtonClick");
        SceneManager.LoadScene("MainScene");
    }
}
