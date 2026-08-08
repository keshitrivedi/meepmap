using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TargetDisplay : MonoBehaviour
{
    [SerializeField] private Sprite[] targetBcchs;
    static public int targetBaccha;
    private int prevTargetBaccha;
    private UnityEngine.UI.Image targetPanel;

    bool isssset;
    int nextBoundary;
    bool firstGroupDone;
    [SerializeField] private RandomAnswer[] konsaCurrent;

    void Start()
    {
        targetPanel = GetComponent<UnityEngine.UI.Image>();
        prevTargetBaccha = -1;
        targetBaccha = Random.Range(0, 4);

        nextBoundary = 0;
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

    void HorribleselectCurrent()
    {
        for (int i = 0; i < konsaCurrent.Length; i++)
        {
            if (konsaCurrent[i].isCurrentQuestion())
            {
                Bacchas currBach = konsaCurrent[i].gameObject.GetComponent<Bacchas>();
                List<BacchaDef> currBachIdx = currBach.bacchaIdxing;
                for (int j = 0; j < currBachIdx.Count; j++)
                {
                    if (currBachIdx[j].isTarget)
                    {
                        targetPanel.sprite = targetBcchs[j];
                    }
                }
            }
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
        // SetTargetSpritePanel();
        HorribleselectCurrent();
    }
}