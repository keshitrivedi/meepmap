using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class TargetDisplay : MonoBehaviour
{
    [SerializeField] private Sprite[] targetBcchs;
    static public int targetBaccha;
    private int prevTargetBaccha;
    private UnityEngine.UI.Image targetPanel;

    bool isssset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPanel = GetComponent<UnityEngine.UI.Image>();
        prevTargetBaccha = -1;
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
        if (Counter.isBreakTime)
        {
            if (!isssset)
            {
                targetBaccha = Random.Range(0, 4);
                isssset = true;
            }
        } else
        {
            isssset = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        // trackTarget();
        // SetTargetSpritePanel();
    }
}
