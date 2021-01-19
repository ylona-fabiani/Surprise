using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGui : MonoBehaviour
{   

    static public int niveauJoueur;

    static public int nombrePlanches;
    static public int nombreTissus;
    static public int nombreCailloux;

    static public int nombrePlanchesNecessaires;
    static public int nombreTissusNecessaires;
    static public int nombreCaillouxNecessaires;

    public Texture2D imagePlanches;
    public Texture2D imageTissus;
    public Texture2D imageCailloux;
    // Start is called before the first frame update
    void Start(){
        nombrePlanches = 0;
        nombreTissus = 0;
        nombreCailloux = 0;

        niveauJoueur = 0;

        nombrePlanchesNecessaires = 5;
        nombreTissusNecessaires = 0;
        nombreCaillouxNecessaires = 0;
        }

    // Update is called once per frame
    void Update()
    {
        if(nombrePlanches >= 5 && niveauJoueur == 0){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            niveauJoueur+=1;
            nombrePlanchesNecessaires = 2;
            nombreTissusNecessaires = 1;
        }

        if(nombrePlanches >= 2 && nombreTissus >= 1  && niveauJoueur == 1){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            nombreTissus = nombreTissus - nombreTissusNecessaires;
            niveauJoueur+=1;
            nombrePlanchesNecessaires = 4;
            nombreTissusNecessaires = 8;
        }

        if(nombrePlanches >= 4 && nombreTissus >= 8  && niveauJoueur == 2){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            nombreTissus = nombreTissus - nombreTissusNecessaires;
            niveauJoueur+=1;
            nombrePlanchesNecessaires = 2;
            nombreTissusNecessaires = 2;
            nombreCaillouxNecessaires = 10;
        }

        if(nombrePlanches >= 2 && nombreTissus >= 2 && nombreCailloux >= 10 && niveauJoueur == 3){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            nombreTissus = nombreTissus - nombreTissusNecessaires;
            nombreCailloux = nombreCailloux - nombreCaillouxNecessaires;
            niveauJoueur+=1;
            nombrePlanchesNecessaires = 0;
            nombreTissusNecessaires = 0;
            nombreCaillouxNecessaires = 0;
        }

    }

    void OnGUI(){
         GUI.Label (new Rect(33,8,80,20), nombrePlanches.ToString() + " / "+ nombrePlanchesNecessaires.ToString() );
         GUI.Label(new Rect(3, 0, imagePlanches.width/8, imagePlanches.height/8), imagePlanches);

         GUI.Label (new Rect(193,8,80,20), nombreTissus.ToString() + " / "+ nombreTissusNecessaires.ToString() );
         GUI.Label(new Rect(163, 0, imageTissus.width/8, imageTissus.height/8), imageTissus);

         GUI.Label (new Rect(113,8,80,20), nombreCailloux.ToString() + " / "+ nombreCaillouxNecessaires.ToString() );
         GUI.Label(new Rect(83, 0, imageCailloux.width/8, imageCailloux.height/8), imageCailloux);

         GUI.Label (new Rect(400,8,80,20), niveauJoueur.ToString());

    }

    public static void increaseNombrePlanches(){nombrePlanches=nombrePlanches+1;}
    public static void increaseNombreTissus(){nombreTissus=nombreTissus+1;}
    public static void increaseNombreCailloux(){nombreCailloux=nombreCailloux+1;}
}