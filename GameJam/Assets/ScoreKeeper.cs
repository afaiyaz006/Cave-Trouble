using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText=gameObject.GetComponent<TextMeshProUGUI>();
        scoreText.SetText("Score: 0");
        score = 0;
    }
     void Update()
    {
        scoreText.SetText("Score " + score.ToString());
    }
}
