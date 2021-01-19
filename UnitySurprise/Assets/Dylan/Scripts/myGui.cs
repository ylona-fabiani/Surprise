using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGui : MonoBehaviour
{
	static public int nombrePlanches;
    static public int nombreTissus;
    static public int nombreCailloux;

	public Texture2D imagePlanches;
    public Texture2D imageTissus;
    public Texture2D imageCailloux;
    // Start is called before the first frame update
    void Start(){
        nombrePlanches = 0;
        nombreTissus = 0;
        nombreCailloux = 0;}

    // Update is called once per frame
    void Update()
    {
    }

    void OnGUI(){
 		GUI.Label (new Rect(33,8,80,20), nombrePlanches.ToString());
 		GUI.Label(new Rect(3, 0, imagePlanches.width/8, imagePlanches.height/8), imagePlanches);

        GUI.Label (new Rect(193,8,80,20), nombreTissus.ToString());
        GUI.Label(new Rect(163, 0, imageTissus.width/8, imageTissus.height/8), imageTissus);

        GUI.Label (new Rect(113,8,80,20), nombreCailloux.ToString());
        GUI.Label(new Rect(83, 0, imageCailloux.width/8, imageCailloux.height/8), imageCailloux);

	}

	public static void increaseNombrePlanches(){nombrePlanches=nombrePlanches+1;}
    public static void increaseNombreTissus(){nombreTissus=nombreTissus+1;}
    public static void increaseNombreCailloux(){nombreCailloux=nombreCailloux+1;}

    public static void setNombrePlanches(int nb){nombrePlanches=nb;}
    public static void setNombreTissus(int nb){nombreTissus=nb;}
    public static void setNombreCailloux(int nb){nombreCailloux=nb;}


}
