using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float hp = 1f;
	float damage = 0f;
	public bool isEnemy = true;
    [SerializeField] GameObject[] pattern;
	[SerializeField] int[] keyHP;

	public GameObject resultPanel;

	public void Damage(int value){
		damage += value;
		//hp = hp - value;
		if (damage >= hp) {
			Destroy (gameObject);
			resultPanel.SetActive(true);
        	Time.timeScale = 0f;
		}
	}

	public float getHprate(){
		return ((hp-damage)/hp) * 100;
	}

	void OnTriggerEnter2D(Collider2D other){
	    if (other.gameObject.tag == "Finish")
	    {
			Destroy(other.gameObject);
			Damage(1);
			GameObject.Find("Player").GetComponent<PlayerManager>().addScore(1);
	    }
	}

    // Start is called before the first frame update
    void Start()
    {
		for(int i = 0;i<pattern.Length;i++){
			pattern[i].SetActive(false);
		}
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(hp);
        for(int i = 0;i<pattern.Length;i++){
			if((hp-damage) > keyHP[i]){
				pattern[i].SetActive(true);
				break;
			}
			else{
				pattern[i].SetActive(false);

			}
		}

    }
}
