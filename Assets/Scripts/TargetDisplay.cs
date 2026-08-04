using UnityEngine;

public class TargetDisplay : MonoBehaviour
{
    [SerializeField] private Sprite[] targetBcchs;
    static public int targetBaccha;
    private int prevTargetBaccha;
    private UnityEngine.UI.Image targetPanel;

    bool isssset;
    int nextBoundary;      // the questionCounter value that triggers the next reroll
    bool firstGroupDone;

    void Start()
    {
        targetPanel = GetComponent<UnityEngine.UI.Image>();
        prevTargetBaccha = -1;
        targetBaccha = Random.Range(0, 4);

        nextBoundary = 0;      // first group starts rolling right away
        firstGroupDone = false;
    }

    void SetTargetSpritePanel()
    {
        if (prevTargetBaccha != targetBaccha)
        {
            prevTargetBaccha = targetBaccha;
            targetPanel.sprite = targetBcchs[targetBaccha];
        }
    }

    void trackTarget()
    {
        if (Counter.questionCounter >= nextBoundary)
        {
            if (!isssset)
            {
                targetBaccha = Random.Range(0, 4);
                isssset = true;

                // first group is size 2, every group after is size 4
                nextBoundary += firstGroupDone ? 4 : 2;
                firstGroupDone = true;
            }
        }
        else
        {
            isssset = false;
        }
    }

    void Update()
    {
        trackTarget();
        SetTargetSpritePanel();
    }
}