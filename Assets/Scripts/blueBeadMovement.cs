using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueBeadMovement : MonoBehaviour
{
    Collider2D m_Collider;

    bool wasJustClicked = true;
    public bool canMove;
    Vector2 playerSize;

    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider2D>();

        playerSize = gameObject.GetComponent<SpriteRenderer>().bounds.extents;
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
                m_Collider.enabled = false;

                if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
                mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
                (mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y ||
                mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y))
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
            m_Collider.enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "eliminate")
        {
            Destroy(gameObject);
        }
    }
}
