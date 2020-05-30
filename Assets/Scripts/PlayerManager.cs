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
    System.DateTime invincible = System.DateTime.Now;
    SpriteRenderer render;

    // Start is called before the first frame update
    void Start()
    {
  		startPos = this.transform.position;
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore(int val){
        this.score += val;
    }

    public int getScore(){
        return this.score;
    }

    public int getLife(){
        return this.life;
    }

    public int getBomb(){
        return this.bomb;
    }

    IEnumerator blink(){
        for(int i = 0;i<6;i++){
            render.color = new Color(1f, 1f, 1f, 0.5f);
            yield return new WaitForSeconds(0.25f);
            render.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(0.25f);
        }
    }

    public void Damage(int dmg)
    {
        if(invincible <= System.DateTime.Now)
        {
            life -= dmg;
            Reset();
        }
    }

    void Reset ()
    {
        transform.position = startPos;
        invincible = System.DateTime.Now.AddSeconds(3);
        StartCoroutine(blink());
    }


	void OnTriggerEnter2D(Collider2D coll){
	    if (coll.gameObject.tag == "Bullet")
	    {
            if(life > 0){
                Damage(1);
            }
            else{
			    Destroy(this.gameObject);
			    SceneManager.LoadScene("StageSelectScene");
            }
	    }
	}
}
