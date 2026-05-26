using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtTimer;

    void Start()
    {
        UpdateScore(0);
        UpdateTimer(60);
    }

    public void UpdateScore(int score)
    {
        txtScore.text = "Score: " + score;
    }

    public void UpdateTimer(float time)
    {
        txtTimer.text = "Time: " + Mathf.Ceil(time);
    }
}