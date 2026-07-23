using UnityEngine;

public class Bacchas : MonoBehaviour
{
    //refrence to QuestionCounter (randomanser)
    public Sprite[] bacchaSprites;
    private int targetBaccha;
    private Transform[] bubbles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void setBaccha()
    {
        for (int i = 0; i < 4; i++)
        {
            bubbles[i] = transform.GetChild(i);
            if (bubbles[i].GetComponent<Tiledef>().isAnswer)
            {
                bubbles[i].GetChild(0).GetComponent<SpriteRenderer>().sprite = bacchaSprites[targetBaccha];
            }
        }
    }

    // function to set target every 4 questions

    // Update is called once per frame
    void Update()
    {
        
    }
}
