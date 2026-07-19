using UnityEngine;
using UnityEngine.EventSystems;

public class Dabao : MonoBehaviour, IPointerDownHandler
{
    Tiledef tile;
    public bool isClicked;
    RandomAnswer parentRow;
    void Awake()
    {
        tile = GetComponent<Tiledef>();
        isClicked = false;
        parentRow = GetComponentInParent<RandomAnswer>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (parentRow.IsUnmarked() && parentRow.isCurrentQuestion())
        { 
            isClicked = true;
            tile.ChangeToClicked();
            // Debug.Log("tidinggggg");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
