using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class StageSelectScene : MonoBehaviour
{
    public GameObject[] stages;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i<stages.Length;i++){
            stages[i].SetActive(false);
        }
        int isCleared = PlayerPrefs.GetInt("cleared");
        for(int i = 0;i<stages.Length;i++){
            if(i > isCleared) break;
            stages[i].SetActive(true);
        }
    }

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
