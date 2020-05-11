using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveTest : MonoBehaviour
{
    // Start is called before the first frame update
    bool touch = false;
    void Start()
    {
    }
    private Vector3 startPos = Vector3.zero;
  	private Vector3 endPos = Vector3.zero;
  	private Vector3 targetPos = Vector3.zero;
    private Vector3 mousepos = Vector3.zero;
  	private bool isClicked = false;

    // Update is called once per frame
  	void Update()
  	{
  		  DragObject();
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
        Debug.Log("Mouse: " + Input.mousePosition);
        Debug.Log("Player: " + transform.position);
  			if (Input.GetMouseButton(0))
        mousepos = Input.mousePosition;
        mousepos.z = 10000;
  			endPos = Camera.main.ScreenToWorldPoint(mousepos);
        Debug.Log("Mouse(World): " + endPos);
  			targetPos = endPos - startPos;
        targetPos = new Vector3(targetPos.x, targetPos.y, gameObject.transform.position.z);
        transform.position = targetPos;
  		}
  	}

}
