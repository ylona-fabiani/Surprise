using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody2D rb;

	public float vitesse_bateau;
	public float vitesse_bateau_max;
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

		if(xmove != 0 || ymove != 0){
			xglisse = xmove;
			yglisse = ymove;
		}
		



		switch(forme){
			case "bateau":
				rb.velocity = new Vector2(xglisse, yglisse) * vitesse_perso;
				break;

			default :
				rb.velocity = new Vector2(xmove, ymove) * vitesse_perso;
				break;
		}
	}

	void setForme(string _forme){
		this.forme = _forme;
	}
}