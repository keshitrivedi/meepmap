using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Tiledef : MonoBehaviour
{
    public bool isAnswer = false;
    private bool isColoured;
    Dabao dabao;
    SpriteRenderer bubbleSprite;
    Color32 defClr;
    RandomAnswer parentRow;
    public bool sahiBhai;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bubbleSprite = GetComponent<SpriteRenderer>();
        defClr = new Color32(193, 193, 193, 255);
        dabao = GetComponent<Dabao>();
        parentRow = GetComponentInParent<RandomAnswer>();
        sahiBhai = false;
    }

    void OnBecameInvisible ()
    {
        bubbleSprite.color = defClr;
        isColoured = false;
        isAnswer = false;
        sahiBhai = false;
        dabao.isClicked = false;
    }

    void ChangeToCorrect()
    {
        if (isAnswer && !isColoured && parentRow.isCurrentQuestion())
        {
            bubbleSprite.color = Color.red;
            isColoured = true;
        }
    }

    public void ChangeToClicked()
    {
        bubbleSprite.color = Color.blue;
    }

    void CorrectClicked()
    {
        if (dabao.isClicked && !sahiBhai)
        {
            if (isAnswer)
            {
                Qp.score++;
            } else
            {
                Qp.score--;
            }
            sahiBhai = true;
            Debug.Log(Qp.score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ChangeToCorrect();
        CorrectClicked();
    }
}
