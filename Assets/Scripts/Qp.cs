using UnityEngine;

public class Qp : MonoBehaviour
{
    [SerializeField] private GameObject question;
    private Vector3 spawnPos = new Vector3(2.8f, -4.25f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void QuestionLagao()
    {
        if (ShiftTimer.canShift)
        {
            Instantiate(question, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        QuestionLagao();
    }
}
