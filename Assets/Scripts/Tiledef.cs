using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Tiledef : MonoBehaviour
{
    public bool isAnswer = false;
    private bool isColoured;
    SpriteRenderer bubbleSprite;
    Color32 defClr;
    Transform bubbleTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bubbleSprite = GetComponent<SpriteRenderer>();
        defClr = new Color32(193, 193, 193, 255);
        bubbleTransform = GetComponent<Transform>();
    }

    void OnBecameInvisible ()
    {
        bubbleSprite.color = defClr;
        isColoured = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAnswer && !isColoured && bubbleTransform.position.y <= 1 && bubbleTransform.position.y >= -1)
        {
            bubbleSprite.color = Color.red;
            isColoured = true;
        }
    }
}
