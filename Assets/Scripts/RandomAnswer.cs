using System;
using UnityEngine;

public class RandomAnswer : MonoBehaviour
{
    Transform rowCont;
    int corrTile;
    Vector3 bottomPos;
    Vector3 targetPos;
    float speed = 50f;
    bool isShifting = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rowCont = gameObject.transform;
        bottomPos = new Vector3(rowCont.position.x, -6.78f, 0f);
        targetPos = new Vector3(rowCont.position.x, rowCont.position.y + 2.26f, rowCont.position.z);
        correctAnswer();
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
            rowCont.transform.position = Vector3.MoveTowards(rowCont.position, targetPos, speed*Time.deltaTime);
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
    }

    // Update is called once per frame
    void Update()
    {
        ShiftUp();
    }
}
