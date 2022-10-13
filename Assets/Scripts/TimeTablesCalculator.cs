using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTablesCalculator : MonoBehaviour
{
    public TextMeshProUGUI changingQuestionNumber;
    public TextMeshProUGUI firstNumber;
    public TextMeshProUGUI secondNumber;

    public TextMeshProUGUI answerOutput;

    public TMP_InputField userAnswer;

    public int firstIntNumber;
    public int secondIntNumber;

    public int answerInt;
    public int userIntAnswer;

    private int quizCounter;

    private void Start()
    {
        quizCounter = 0;
        changingQuestionNumber.text = quizCounter.ToString();
    }

    public void RunQuiz()
    {
        for (int i = 0; i < 10; i++)
        {
            quizCounter++;
            CalculateTimesTable();
            changingQuestionNumber.text = quizCounter.ToString();
        }
    }

    public void CalculateTimesTable()
    {
        firstIntNumber = TableSelectionManager.MyInstance.selectedTable;
        secondIntNumber = Random.Range(1, 13);

        answerInt = firstIntNumber * secondIntNumber;

        firstNumber.text = firstIntNumber.ToString();
        secondNumber.text = secondIntNumber.ToString();

        //testing call needs changed to be active on user input
        Debug.Log("Answer = " + answerInt);
        //SubmitAnswer();
    }

    public void SubmitAnswer()
    {
        int.TryParse(userAnswer.text, out userIntAnswer);
        Debug.Log("User Input: " + userIntAnswer);

        if (answerInt == userIntAnswer)
        {
            //correct
            answerOutput.text = "Correct! " + firstIntNumber.ToString() + " x " + secondIntNumber.ToString() + " = " + answerInt.ToString();
        }
        else
        {
            //incorrect
            answerOutput.text = "Incorrect " + firstIntNumber.ToString() + " x " + secondIntNumber.ToString() + " = " + answerInt.ToString();
        }
    }
}
