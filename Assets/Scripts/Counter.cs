using UnityEngine;

public class Counter : MonoBehaviour
{
    static public int questionCounter;
    static public bool isQuestionRecorded;
    static public float speed = 50f;
    // static public bool isBreakTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 50f;
        isQuestionRecorded = false;
        questionCounter = 0;
        // isBreakTime = false;
    }

    void Awake()
    {
        // isBreakTime = false;
    }

    void QuestionSegmenter()
    {
        if (!isQuestionRecorded && questionCounter % 4 == 0 && ShiftTimer.shiftTime >= 0.4f)
        {
            // ShiftTimer.shiftTime -= 0.1f;
            // ShiftTimer.shiftTime = Mathf.Max(0.4f, ShiftTimer.shiftTime - 0.1f);
            isQuestionRecorded = true;
            // isBreakTime = true;
            // Debug.Log(ShiftTimer.shiftTime);
            // Debug.Log($"count: {questionCounter}, Time: {ShiftTimer.shiftTime}");
        }

        if (questionCounter % 4 != 0)
        {
            isQuestionRecorded = false;
            // isBreakTime = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // QuestionSegmenter();
    }
}
