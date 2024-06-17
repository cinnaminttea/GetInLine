using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scoreWhite : MonoBehaviour
{
    public ScoreScript score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "eliminate")
        {
            Debug.Log("oop");
            Destroy(gameObject);

            score.AddScoreB();
        }
    }
}
