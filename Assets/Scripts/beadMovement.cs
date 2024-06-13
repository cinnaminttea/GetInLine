using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beadMovement : MonoBehaviour
{
    bool wasJustClicked = true;
    public bool canMove;
    Rigidbody2D rb;
    Collider2D playerCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (wasJustClicked)
            {
                wasJustClicked = false;

                if (playerCollider.OverlapPoint(mousePos))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

            if (canMove)
            {
                transform.position = mousePos;
            }
        }
        else
        {
            wasJustClicked = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "eliminate")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "disable")
        {
            canMove = false;
        }
    }
}
