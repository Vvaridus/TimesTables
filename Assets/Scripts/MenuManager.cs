using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public CanvasGroup mainMenuCanvas;
    public CanvasGroup learnCanvas;
    public CanvasGroup tablesCanvas;
    public CanvasGroup quizCanvas;

    public void MoveFromTablesToQuiz()
    {
        tablesCanvas.alpha = 0;
        tablesCanvas.interactable = false;
        tablesCanvas.blocksRaycasts = false;

        quizCanvas.alpha = 1;
        quizCanvas.interactable = true;
        quizCanvas.blocksRaycasts = true;
    }

    public void MoveFromQuizToTables()
    {
        tablesCanvas.alpha = 1;
        tablesCanvas.interactable = true;
        tablesCanvas.blocksRaycasts = true;

        quizCanvas.alpha = 0;
        quizCanvas.interactable = false;
        quizCanvas.blocksRaycasts = false;
    }
}
