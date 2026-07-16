using System;
using UnityEngine;

public class RandomAnswer : MonoBehaviour
{
    Transform rowCont;
    int corrTile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rowCont = gameObject.transform;
        correctAnswer();
    }

    void correctAnswer()
    {
        corrTile = UnityEngine.Random.Range(0, 3);
        Tiledef chosenOne = rowCont.GetChild(corrTile).GetComponent<Tiledef>();
        chosenOne.isAnswer = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
