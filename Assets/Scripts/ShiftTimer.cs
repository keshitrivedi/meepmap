using UnityEngine;

public class ShiftTimer : MonoBehaviour
{
    public static bool canShift = false;
    static public float shiftTime = 1f;
    static public float breakTime = 2f;
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = shiftTime;
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer > 0)
        {
            canShift = false;
        } else
        {   
            timer = shiftTime;
            // timer = shiftTime;
            // if (Counter.questionCounter % 4 == 0)
            // {
            //     timer = breakTime;
            //     Debug.Log("breakdhuew");
            // } else
            // {
            //     timer = shiftTime;
            // }
            canShift = true;
        }
        
    }
}
