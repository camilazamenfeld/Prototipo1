using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtTimer;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(0);
    }
public void UpdateScore(int score)
{
   txtScore.text = "Score: " + score.ToString();
}
 
}
