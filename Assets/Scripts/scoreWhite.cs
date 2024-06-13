using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreWhite : MonoBehaviour
{
    public TMP_Text WhiteScoreText;
    private int whiteScore;
    public GameObject WhiteWinPanel;

    void Update()
    {
        if (whiteScore >= 6)
        {
            WhiteWinPanel.SetActive(true);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "eliminate")
        {
            Debug.Log("oop");
            AddScore();
            Destroy(gameObject);
            WhiteScoreText.text = $"{whiteScore}";
        }
    }

    void AddScore()
    {
        whiteScore++;
        WhiteScoreText.text = whiteScore.ToString();
    }
}
