using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake() {

    }

    public void ChangeOptionScene()
    {
        SoundManager.instance.PlayClickButton();
        SceneManager.LoadScene("OptionScene");
    }

    public void ChangeShopScene()
    {
        SoundManager.instance.PlayClickButton();
        SceneManager.LoadScene("ShopScene");
    }

    public void ChangeStageSelectScene()
    {
        SoundManager.instance.PlayClickButton();
        SceneManager.LoadScene("StageSelectScene");
    }
}
