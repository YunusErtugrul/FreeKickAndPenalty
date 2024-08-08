using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    private float moveSpeed = 5f;
    public Vector2 minBounds;
    public Vector2 maxBounds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTarget();
    }

    void MoveTarget()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
        newPosition.y = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);


        transform.position = newPosition;
    }
}
