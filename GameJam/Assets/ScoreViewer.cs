using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ScoreViewer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject currentScore;
    private TextMeshProUGUI scoreTextCurrent;

    public GameObject highScoreObject;
    private TextMeshProUGUI highScoreText;
    void Start()
    {
        scoreTextCurrent = currentScore.GetComponent<TextMeshProUGUI>();
        highScoreText = highScoreObject.GetComponent<TextMeshProUGUI>();

        scoreTextCurrent.SetText("Score: " + ScoreKeeper.score.ToString());
        float highScore = PlayerPrefs.GetFloat("HighScore");
        if (highScore < ScoreKeeper.score)
        {
            highScore = ScoreKeeper.score;
            PlayerPrefs.SetFloat("HighScore", highScore);

        }
        highScoreText.SetText("HighScore: " + highScore);
    }

    // Update is called once per frame
    public  void loadMenu()
    {
        SceneManager.LoadScene(1);
    }
}
