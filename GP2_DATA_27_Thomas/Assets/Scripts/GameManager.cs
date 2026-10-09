using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null)
            Destroy(this);
        else
            Instance = this;
    }

    private int score = 0;
    
    private List<QuestionsSO> _questionsList = new List<QuestionsSO>();
    
    private void AddQuestion(QuestionsSO question) =>  _questionsList.Add(question);
    private void RemoveQuestion(QuestionsSO question) =>  _questionsList.Remove(question);
    
    private void SelectAnswer()
}
