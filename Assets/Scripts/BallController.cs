using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private GameObject target;
    private GameObject player;
    private Rigidbody ballRB;
    private float speed = 35f;
    public bool score = false;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target");
        player = GameObject.Find("Ball");
        ballRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ballRB.AddForce((target.gameObject.transform.position - player.transform.position).normalized * speed, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("goal"))
        {
            Debug.Log("Scoreee!");
            score = true;
        }
    }
}
