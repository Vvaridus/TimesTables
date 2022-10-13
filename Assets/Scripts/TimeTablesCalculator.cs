using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTablesCalculator : MonoBehaviour
{
    public TextMeshProUGUI firstNumber;
    public TextMeshProUGUI secondNumber;

    public int IntFirstNumber;
    public int IntSecondNumber;

    public int answer;

    private void Start()
    {
        CalculateTimesTable();
    }

    public void CalculateTimesTable()
    {
        IntFirstNumber = Random.Range(1, 13);
        IntSecondNumber = Random.Range(1, 13);

        answer = IntFirstNumber * IntSecondNumber;

        firstNumber.text = IntFirstNumber.ToString();
        secondNumber.text = IntSecondNumber.ToString();

        Debug.Log("Answer = " + answer);
    }
}
