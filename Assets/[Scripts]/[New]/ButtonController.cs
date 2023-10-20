using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.UI;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject playerShip; // Reference to your player ship GameObject
    private bool isMovingUp = false;
    private bool isMovingDown = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject.name == "MoveUp_btn")
        {
            isMovingUp = true;
        }
        else if (eventData.pointerCurrentRaycast.gameObject.name == "MoveDown_btn")
        {
            isMovingDown = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isMovingUp = false;
        isMovingDown = false;
    }

    void Update()
    {
        if (isMovingUp)
        {
            playerShip.GetComponent<SpaceshipController>().MoveUp();
        }
        else if (isMovingDown)
        {
            playerShip.GetComponent<SpaceshipController>().MoveDown();
        }
    }
}
