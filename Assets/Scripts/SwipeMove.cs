using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeMove : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (swipeControls.SwipeLeft)
          desiredPosition += Vector3.left;
        if (swipeControls.SwipeRight)
          desiredPosition += Vector3.right;
        if (swipeControls.SwipeUp)
          desiredPosition += Vector3.up;
        if (swipeControls.SwipeDown)
          desiredPosition += Vector3.down;

        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 1000 * Time.deltaTime);
        if (swipeControls.Tap)
            Debug.Log("Tap");
    }
}
