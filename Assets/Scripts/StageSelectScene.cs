using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

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
      SceneManager.LoadScene("InGameScene");
    }

    public void ChangeMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
