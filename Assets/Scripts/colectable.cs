using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colectable : MonoBehaviour
{

    Text txtScore;
    [SerializeField]
    int currentScore;

    [SerializeField]
    int points;

    public int Points {get => points;}

    void Awake()
    {
        txtScore = GetComponent<Text>();
    }

    public void AddPoints(int points)
    {
        currentScore += points;
        txtScore.text = $"score: (currentScore) pts";
    }
}
