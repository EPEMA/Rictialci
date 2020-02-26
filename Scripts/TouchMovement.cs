using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement   : MonoBehaviour{

    public float speed = 15f;
    public float mapWidth = 5f;

    private Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        int i = 0;
        while(i < Input.touchCount){
            if(Input.GetTouch(i).position.x > mapWidth / 2) {
                Move(1.0f);
            }
            if(Input.GetTouch(i).position.x < mapWidth / 2) {
                Move(-1.0f);
            }
            ++i;
        }
    }

    void FixedUpdate()
    {
//    #if UNITY_EDITOR
//    Move(Input.GetAxis("Horizontal"))
//    #endif
    }

    private void Move (float horizontalInput)
    {
        rb.AddForce(new Vector2(horizontalInput * speed * Time.deltaTime, 0));

    }
}
