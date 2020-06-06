using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class StageSelectScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeInGameScene()
    {
        string name =  EventSystem.current.currentSelectedGameObject.name;
        PlayerPrefs.SetString("stage", name);
        LoadingSceneManager.LoadScene("InGameScene");
    }

    public void ChangeMainScene()
    {
        LoadingSceneManager.LoadScene("MainScene");
    }
}
