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
        SceneManager.LoadScene("InGameScene");
        Debug.Log(name);
        PlayerPrefs.SetString("stage", name);
    }

    public void ChangeMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
