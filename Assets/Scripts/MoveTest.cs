using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class MoveTest : MonoBehaviour
{

	private Vector3 startPos = Vector3.zero;
  	private Vector3 endPos = Vector3.zero;
  	private Vector3 targetPos = Vector3.zero;
    private Vector3 mousepos = Vector3.zero;
  	private bool isClicked = false;

    void Start()
    {

    }
    public float speed = 0.1f;

    // Update is called once per frame
  	void Update()
  	{
  		//DragObject();
        SlideMove();
  	}

    void SlideMove()
    {
        if (Input.touchCount >0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            Debug.Log("Touch: " + touchDeltaPosition);
            Debug.Log("Player: " + transform.position);
            transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
        }
        Vector3 worldpos = Camera.main.WorldToViewportPoint(this.transform.position);
        if (worldpos.x < 0f) worldpos.x = 0f;
        if (worldpos.y < 0f) worldpos.y = 0f;
        if (worldpos.x > 1f) worldpos.x = 1f;
        if (worldpos.y > 1f) worldpos.y = 1f;
        this.transform.position = Camera.main.ViewportToWorldPoint(worldpos);
    }


  	void DragObject()
  	{
  		if (Input.GetMouseButtonDown(0))
  		{
  			startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  			isClicked = true;
  		}
        else if (Input.GetMouseButtonUp(0))
  		{
  			startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  			isClicked = false;
  		}
  		else if (isClicked)
  		{
        	//Debug.Log("isClicked");
        	//Debug.Log("Mouse: " + Input.mousePosition);
  			if (Input.GetMouseButton(0))
        	mousepos = Input.mousePosition;
        	mousepos.z = 10000;
  			endPos = Camera.main.ScreenToWorldPoint(mousepos);
        	//Debug.Log("Mouse(World): " + endPos);
  			targetPos = endPos - startPos;
        	targetPos = new Vector3(targetPos.x, targetPos.y, gameObject.transform.position.z);
        	transform.position = targetPos;
		    //Debug.Log("Player: " + transform.position);
  		}

  	}	
}