using UnityEngine;

public class ShiftTimer : MonoBehaviour
{
    public static bool canShift = false;
    private float shiftTime = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shiftTime > 0)
        {
            shiftTime -= Time.deltaTime;
            canShift = false;
        } else
        {
            shiftTime = 3f;
            canShift = true;
        }
        
    }
}
