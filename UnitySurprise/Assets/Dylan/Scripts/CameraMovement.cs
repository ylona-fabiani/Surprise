using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float vitesse_bateau;
    public float vitesse_perso;
    public string forme;

    private float xglisse;
    private float yglisse;


    void Start(){

    }

    void Update()
    {

        float xmove = Input.GetAxisRaw("Horizontal");
        float ymove = Input.GetAxisRaw("Vertical");

        if (xmove != 0 || ymove != 0){
            xglisse = xmove;
            yglisse = ymove;
        }

        switch(forme){

            case "bateau":
                rb.velocity = new Vector2(xglisse, yglisse) * vitesse_bateau;
                break;

            case "bateau_rame":
                rb.velocity = new Vector2(xglisse, yglisse) * vitesse_bateau;
                break;

            default :
                rb.velocity = new Vector2(xmove, ymove) * vitesse_perso;
                break;
        }
    }
}