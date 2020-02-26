using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour{

    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;
    public float pointsPerSeconds;

    public bool scoreIncreasing;

    // Start is called before the first frame update
    void Start() 
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update() 
    {

        if (scoreIncreasing)
        {
            scoreCount += pointsPerSeconds * Time.deltaTime;
            PlayerPrefs.SetFloat ("Score", scoreCount);
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat ("HighScore", highScoreCount);
        }

        scoreText.text = "Score " + Mathf.Round (scoreCount);
        highScoreText.text = "HighScore " + Mathf.Round (highScoreCount);
    }
}
