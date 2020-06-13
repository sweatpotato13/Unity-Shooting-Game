using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public bool isVibrate = true;
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
        if(PlayerPrefs.HasKey("isVibrate")){
            string value = PlayerPrefs.GetString("isVibrate", "false");
            isVibrate = System.Convert.ToBoolean(value);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetVibrate(bool val)
    {
        isVibrate = val;
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

    public void setBomb(int bombCount){
        this.bomb = bombCount;
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
            if(SoundManager.instance != null)
                SoundManager.instance.PlaySound("Explode_02",  SoundManager.instance.masterVolumeSFX);
            if(isVibrate)
                Handheld.Vibrate();
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
                SoundManager.instance.StartBGM();
			    SceneManager.LoadScene("StageSelectScene");
            }
	    }
	}
}
