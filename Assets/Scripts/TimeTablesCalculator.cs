using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTablesCalculator : MonoBehaviour
{
    public TextMeshProUGUI firstNumber;
    public TextMeshProUGUI secondNumber;    

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

        Debug.Log("Answer = " + answerInt);

        SubmitAnswer();
    }

    public void SubmitAnswer()
    {
        int.TryParse(userAnswer.text, out userIntAnswer);
        Debug.Log("User Input: " + userIntAnswer);
    }
}
