using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllerPlayer : MonoBehaviour
{
    static public VectorMovement playerVector = new VectorMovement();

    private bool isRightButtonPressed = false;
    private bool isLeftButtonPressed = false;

    public void RightDownButton()
    {
        isRightButtonPressed = true;
        playerVector.x = 1;
    }

    public void LeftDownButton()
    {
        isLeftButtonPressed = true;
        playerVector.x = -1;
    }

    public void RightUpButton()
    {
        isRightButtonPressed = false;
    }

    public void LeftUpButton()
    {
        isLeftButtonPressed = false;
    }

    void LateUpdate()
    {
        if((isLeftButtonPressed && isRightButtonPressed) || (isLeftButtonPressed == false && isRightButtonPressed == false)) {
            playerVector.x = 0;
        }
        //Debug.Log(playerVector.x + $" isLeftButtonPressed {isLeftButtonPressed} , isRightButtonPressed {isRightButtonPressed}");
    }
}

[System.Serializable]
public struct VectorMovement
{
    public int x { get; set; }
}