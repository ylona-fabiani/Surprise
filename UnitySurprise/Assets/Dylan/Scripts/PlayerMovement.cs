using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float vitesse_bateau;
    public float vitesse_perso;
    public string forme;


    void Start(){

    }

    void Update()
    {

        float xmove = Input.GetAxisRaw("Horizontal");
        float ymove = Input.GetAxisRaw("Vertical");

        switch(forme){

            case "bateau":
                rb.AddForce(new Vector2(xmove, ymove) * vitesse_bateau);
                break;

            default :
                rb.velocity = new Vector2(xmove, ymove) * vitesse_perso;
                break;
        }
    }
}