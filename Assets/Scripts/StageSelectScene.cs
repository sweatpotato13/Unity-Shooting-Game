using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class StageSelectScene : MonoBehaviour
{
    public void ChangeInGameScene(int stageLevel)
    {
        
        string sceneName = "InGameScene";
        string level = stageLevel.ToString();
        LoadingSceneManager.LoadScene(sceneName + level);
    }

    public void ChangeMainScene()
    {
        LoadingSceneManager.LoadScene("MainScene");
    }
}
