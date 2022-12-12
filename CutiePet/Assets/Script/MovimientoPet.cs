using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPet : MonoBehaviour
{
    public float moveLeft;
    public float moveRight;
    public bool itsMoving;
    public Rigidbody petBody;
    void Start()
    {
        petBody = GetComponent<Rigidbody>();
        itsMoving = false;
    }

    public void Movement()
    {
        moveLeft = -speed;
    }
    void Update()
    {
        
    }
}
