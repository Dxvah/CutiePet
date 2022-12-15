using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerechaIzquierda : MonoBehaviour
{
    bool buttonPressLeft = false;
    bool buttonPressRight = false;
    [SerializeField]
    MovimientoPet movimiento;

    private void Update()
    {
        if(buttonPressLeft)
        {
            movimiento.Mover(1);
        }
        else if(buttonPressRight)
        {

            movimiento.Mover(-1);
        }
    }
    public void OnPointerDownLeft()
    {
        buttonPressLeft = true;

    }
    public void OnPointerDownRight()
    {
        buttonPressRight = true;

    }
    public void OnPointerUpLeft()
    {
        buttonPressLeft = false;

    }
    public void OnPointerUpRight()
    {
        buttonPressRight = false;

    }
}
