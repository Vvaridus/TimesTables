using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTablesCalculator : MonoBehaviour
{
    public TextMeshProUGUI firstNumber;
    public TextMeshProUGUI secondNumber;

    public TextMeshProUGUI answerOutput;

    public TMP_InputField userAnswer;

    public int firstIntNumber;
    public int secondIntNumber;

    public int answerInt;
    public int userIntAnswer;

    private void Start()
    {
    }

    public void CalculateTimesTable()
    {
        firstIntNumber = Random.Range(1, 13);
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
