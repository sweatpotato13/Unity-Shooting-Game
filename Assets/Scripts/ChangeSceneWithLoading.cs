using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithLoading : MonoBehaviour
{
     public void ChangeScene(string sceneName)
    {
        LoadingSceneManager.LoadScene(sceneName);
    }

    public void ChangeInGameScene(int stageLevel)
    {
        
        string sceneName = "InGameScene";
        string level = stageLevel.ToString();
        LoadingSceneManager.LoadScene(sceneName + level);
    }
}
