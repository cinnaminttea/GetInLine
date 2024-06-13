using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreBlack : MonoBehaviour
{
    public TMP_Text BlackScoreText;
    private int blackScore;
    public GameObject BlackWinPanel;

    void Update()
    {
        if (blackScore >= 6)
        {
            BlackWinPanel.SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "eliminate")
        {
            Debug.Log("oop");
            AddScore();
            Destroy(gameObject);
            BlackScoreText.text = $"{blackScore}";
        }
    }

    void AddScore()
    {
        blackScore++;
        BlackScoreText.text = blackScore.ToString();
    }
}
