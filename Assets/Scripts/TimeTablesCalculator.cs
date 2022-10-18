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

    public TextMeshProUGUI correctScoreNumber;
    public TextMeshProUGUI incorrectScoreNumber;

    public int firstIntNumber;
    public int secondIntNumber;

    public int answerInt;
    public int userIntAnswer;

    private int quizCounter;

    private int userScoreCorrect;
    private int userScoreIncorrect;

    private void Start()
    {
        quizCounter = 1;
        userScoreCorrect = 0;
        userScoreIncorrect = 0;
        changingQuestionNumber.text = quizCounter.ToString();
    }

    public void CalculateTimesTable()
    {
        answerOutput.text = "";
        userAnswer.text = "";

        firstIntNumber = TableSelectionManager.MyInstance.selectedTable;
        secondIntNumber = Random.Range(1, 13);
        firstNumber.text = firstIntNumber.ToString();
        secondNumber.text = secondIntNumber.ToString();

        MultiplyTwoNumbers(firstIntNumber, secondIntNumber);

        //testing call needs changed to be active on user input
        Debug.Log("Answer = " + answerInt);
    }

    public void MultiplyTwoNumbers(int numberOne, int numberTwo)
    {
        answerInt = numberOne * numberTwo;        
    }

    public void SubmitAnswer()
    {
        int.TryParse(userAnswer.text, out userIntAnswer);

        if (answerInt == userIntAnswer)
        {
            //correct
            answerOutput.text = "Correct! " + firstIntNumber.ToString() + " x " + secondIntNumber.ToString() + " = " + answerInt.ToString();
            userScoreCorrect++;
            correctScoreNumber.text = userScoreCorrect.ToString();
            changingQuestionNumber.text = quizCounter.ToString();
        }
        else
        {
            //incorrect
            answerOutput.text = "Incorrect " + firstIntNumber.ToString() + " x " + secondIntNumber.ToString() + " = " + answerInt.ToString();
            userScoreIncorrect++;
            incorrectScoreNumber.text = userScoreIncorrect.ToString();
            changingQuestionNumber.text = quizCounter.ToString();
        }

        quizCounter++;
    }
}
