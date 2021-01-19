using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer spriteRenderer;

    public float vitesse_bateau;
    public float vitesse_perso;
    public string forme;

    //public float xglisse = 0;
    //public float yglisse = 0;


    void Start(){

    }

    void Update()
    {

    	float xmove = Input.GetAxisRaw("Horizontal");
		float ymove = Input.GetAxisRaw("Vertical");

		Flip(xmove);
		anim.SetFloat("Speed", Mathf.Abs(xmove));

    	switch(forme){

    		case "bateau":
		    	rb.AddForce(new Vector2(xmove, ymove) * vitesse_bateau);
		    	break;

		    default :
		    	rb.velocity = new Vector2(xmove, ymove) * vitesse_perso;
		    	break;
    	}
    }

    void Flip(float speed){
    	if(speed > 0.1f){
    		spriteRenderer.flipX = false;
    	}
    	else if(speed < -0.1f){
    		spriteRenderer.flipX = true;
    	}
    }
}