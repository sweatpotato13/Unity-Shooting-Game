using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp = 1;
	public bool isEnemy = true;
    [SerializeField] GameObject[] pattern;
	[SerializeField] int[] keyHP;

	public void Damage(int value){
		hp = hp - value;
		if (hp <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
	    if (other.gameObject.tag == "Finish")
	    {
			Destroy(other.gameObject);
			Damage(1);
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
        for(int i = 0;i<pattern.Length;i++){
			if(hp > keyHP[i]){
				pattern[i].SetActive(true);
				break;
			}
			else{
				pattern[i].SetActive(false);
			}
		}

    }
}
