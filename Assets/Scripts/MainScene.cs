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

    public void ChangeOptionScene()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void ChangeShopScene()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void ChangeStageSelectScene()
    {
      SceneManager.LoadScene("StageSelectScene");
    }
}
