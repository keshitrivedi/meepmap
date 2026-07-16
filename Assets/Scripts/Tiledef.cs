using UnityEngine;
using UnityEngine.Rendering;

public class Tiledef : MonoBehaviour
{
    public bool isAnswer = false;
    private bool isColoured;
    SpriteRenderer bubbleSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bubbleSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAnswer && !isColoured)
        {
            bubbleSprite.color = Color.red;
            isColoured = true;
        }
    }
}
