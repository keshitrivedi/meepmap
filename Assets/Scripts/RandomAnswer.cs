using System;
using UnityEngine;

public class RandomAnswer : MonoBehaviour
{
    Transform rowCont;
    int corrTile;
    Vector3 bottomPos;
    Vector3 targetPos;
    bool isShifting = false;

    bool hasPassed;
    
    Bacchas bacchaScr;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rowCont = gameObject.transform;
        bottomPos = new Vector3(rowCont.position.x, -6.78f, 0f);
        targetPos = new Vector3(rowCont.position.x, rowCont.position.y + 2.26f, rowCont.position.z);
        correctAnswer();
        hasPassed = false;
        bacchaScr = GetComponent<Bacchas>();
    }

    void correctAnswer()
    {
        for (int i = 0; i < 4; i++)
        {
            rowCont.GetChild(i).GetComponent<Tiledef>().isAnswer = false;
        }

        corrTile = UnityEngine.Random.Range(0, 4);
        Tiledef chosenOne = rowCont.GetChild(corrTile).GetComponent<Tiledef>();
        chosenOne.isAnswer = true;
    }

    void ShiftUp()
    {
        if (ShiftTimer.canShift)
        {
            // rowCont.transform.position = new Vector3(rowCont.position.x, rowCont.position.y + 2.26f, rowCont.position.z);
            // targetPos = new Vector3(rowCont.position.x, rowCont.position.y + 2.26f, rowCont.position.z);
            targetPos = rowCont.position + Vector3.up * 2.26f;
            isShifting = true;
            // rowCont.transform.position = Vector3.MoveTowards(rowCont.position, targetPos, speed*Time.deltaTime);
        }

        if (isShifting)
        {
            rowCont.transform.position = Vector3.MoveTowards(rowCont.position, targetPos, Counter.speed*Time.deltaTime);
            if (rowCont.position == targetPos)
            {
                isShifting = false;
            }
        }
    }

    void OnBecameInvisible()
    {
        rowCont.transform.position = bottomPos;
        isShifting = false;
        targetPos = bottomPos;
        correctAnswer();
        hasPassed = false;

        for (int i = 0; i < 4; i++)
        {
            rowCont.GetChild(i).GetComponent<Dabao>().isClicked = false;
        }

        bacchaScr.AglaAgla();
    }

    public bool IsUnmarked()
    {
        for (int i = 0; i < 4; i++)
        {
            if (rowCont.GetChild(i).GetComponent<Dabao>().isClicked)
            {
                return false;
            }
        }
        return true;
    }

    public bool isCurrentQuestion()
    {
        if(rowCont.transform.position.y >= -1 && rowCont.transform.position.y <= 1)
        {
            // hasPassed = true;
            return true;
        }
        return false;
    }

    void QuestionCounter()
{
    if (isCurrentQuestion())
    {
        if (!hasPassed)
        {
            Counter.questionCounter++;
            hasPassed = true;
            Debug.Log(Counter.questionCounter);
        }
    }
    else
    {
        hasPassed = false;
    }
}

    // Update is called once per frame
    void Update()
    {
        QuestionCounter();
        ShiftUp();
    }
}
