using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "QuizQuestion", fileName = "NewQuestion")]

public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int CorrectAnswerIndex;
    public string GetQuestion()
    {
        return question;

    }

    public int GetCorrectAnswerIndex()
    {
        return CorrectAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}
