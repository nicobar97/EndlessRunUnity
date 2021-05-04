using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text score;
    public Text highScore;
    int number = 0;

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        StartCoroutine(AddScore());
    }

    IEnumerator AddScore() {
        yield return new WaitForSeconds(1f);
        number += 2;
        score.text = number.ToString();

        if(number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }
        PlayerPrefs.Save();
        StartCoroutine(AddScore());
    }
}
