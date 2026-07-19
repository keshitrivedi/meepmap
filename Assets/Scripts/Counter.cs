using UnityEngine;

public class Counter : MonoBehaviour
{
    static public int questionCounter;
    static public bool isQuestionRecorded;
    static public float speed = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 50f;
        isQuestionRecorded = false;
        questionCounter = 0;
    }

    void QuestionSegmenter()
    {
        if (!isQuestionRecorded && questionCounter % 4 == 0 && ShiftTimer.shiftTime >= 0.2f)
        {
            ShiftTimer.shiftTime -= 0.1f;
            isQuestionRecorded = true;
            Debug.Log(ShiftTimer.shiftTime);
        }

        if (questionCounter % 4 != 0)
        {
            isQuestionRecorded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        QuestionSegmenter();
    }
}
