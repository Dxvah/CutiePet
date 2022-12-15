using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovimientoPet : MonoBehaviour
{
    [SerializeField]
    bool buttonPress = false;
    [SerializeField]
    GameObject pet;
    public Vector3 force;
    


    public void Mover(float movimiento)
    {
        Vector3 pos = new Vector3(movimiento, 0f, 0f);
        pet.transform.Translate(pos * Time.deltaTime);
    }
    private void Update()
    {
        
    }

   
}