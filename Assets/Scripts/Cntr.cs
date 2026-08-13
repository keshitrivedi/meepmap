using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Cntr : MonoBehaviour
{
    [SerializeField] private Sprite[] nums;
    private UnityEngine.UI.Image image;
    int maxCtr = 4;
    int ptr = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<UnityEngine.UI.Image>();
    }

    void SetNum()
    {
        if (ptr == maxCtr)
        {
            ptr = 0;
        }

        image.sprite = nums[ptr];

        if (ShiftTimer.canShift)
        {
            ptr ++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        SetNum();
    }
}
