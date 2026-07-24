using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BacchaDef
{
    public int id;
    public Sprite sprite;
    public bool isTarget;
    public bool isMarked;
    public BacchaDef(int id, Sprite sprite, bool isTarget=false, bool isMarked=false)
    {
        this.id = id;
        this.sprite = sprite;
        this.isTarget = isTarget;
        this.isMarked = isMarked;
    }
}

public class Bacchas : MonoBehaviour
{
    //refrence to QuestionCounter (randomanser)
    [SerializeField] private Sprite[] bacchaSprites;
    private int targetBaccha;
    private Transform[] bubbles;
    // List<int> remainingSprites = new List<int> {0, 1, 2, 3};
    // bool isAnswerMarked;

    // Dictionary<int, Sprite> spriteIndexD = new Dictionary<int, Sprite>();
    private List<BacchaDef> bacchaIdxing = new List<BacchaDef>();
    bool sethai;

    void Awake()
    {
        targetBaccha = 2;
        bubbles = new Transform[4];
        sethai = false;

        for (int i = 0; i < bacchaSprites.Length; i++)
        {
            bacchaIdxing.Add(new BacchaDef(i, bacchaSprites[i]));
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // isAnswerMarked = false;
    }

    void setBaccha()
    {   if (!sethai)
        {
            for (int i = 0; i < 4; i++)
            {
                bubbles[i] = transform.GetChild(i);
                if (bubbles[i].GetComponent<Tiledef>().isAnswer)
                {
                    bubbles[i].GetChild(0).GetComponent<SpriteRenderer>().sprite = bacchaIdxing[targetBaccha].sprite;
                    bacchaIdxing[targetBaccha].isTarget = true;
                    bacchaIdxing[targetBaccha].isMarked = true;
                    // isAnswerMarked = true;
                } else
                {
                    int randomBaccha = Random.Range(0, 4);
                    while (bacchaIdxing[randomBaccha].isMarked)
                    {
                        randomBaccha = Random.Range(0, 4);
                    }

                    bacchaIdxing[randomBaccha].isMarked = true;
                    bubbles[i].GetChild(0).GetComponent<SpriteRenderer>().sprite = bacchaIdxing[randomBaccha].sprite;
                }
            }
            sethai = true;
        }
    }

    public void ResetAllBaccha()
    {
        for (int i = 0;  i < bacchaIdxing.Count; i++)
        {
            bacchaIdxing[i].isTarget = false;
            bacchaIdxing[i].isMarked = false;
        }
    }

    // function to set target every 4 questions

    // Update is called once per frame
    void Update()
    {
        setBaccha();
    }
}
