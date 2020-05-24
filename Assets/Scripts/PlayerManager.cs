using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int life = 3;
    public int bomb = 3;
    public int score = 0;
	private Vector3 startPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
  		startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int val){
        this.score += val;
    }

	void OnTriggerEnter2D(Collider2D coll){
	    if (coll.gameObject.tag == "Bullet")
	    {
            if(life > 0){
                life--;
        	    transform.position = startPos;
            }
            else{
			    Destroy(this.gameObject);
			    SceneManager.LoadScene("StageSelectScene");
            }
	    }
	}
}
