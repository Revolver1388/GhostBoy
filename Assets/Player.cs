using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speedX = 3;
    public float speedY = 3.4f;

    private Rigidbody2D body;

	// Use this for initialization
	void Start () {
     body = GetComponent<Rigidbody2D>();

	}

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveH, moveY);
        body.velocity = speedX * movement;

    }
    // Update is called once per frame
    void Update () {
		
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
