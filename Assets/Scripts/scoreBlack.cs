using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreBlack : MonoBehaviour
{
    public ScoreScript score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "eliminate")
        {
            Debug.Log("oop");
            Destroy(gameObject);

            score.AddScoreW();
        }
    }

}
