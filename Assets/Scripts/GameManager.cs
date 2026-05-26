using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 60f;

    private UIManager uiManager;

    void Start()
    {
        uiManager = GameObject.FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;

            uiManager.UpdateTimer(timeLeft);
        }
        else
        {
            timeLeft = 0;
            Debug.Log("Loss");
        }
    }
}