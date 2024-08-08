using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 startPosition;
    private BallController ballController;
    // Start is called before the first frame update
    void Start()
    {
        ballController = GameObject.Find("Ball").gameObject.GetComponent<BallController>();
        startPosition = ballController.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && ballController.score == true)
        {
            ballController.transform.position = startPosition;
            ballController.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ballController.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            ballController.score = false;
        }
    }
}
