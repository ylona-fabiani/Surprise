using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGui : MonoBehaviour
{   

    static public int niveauJoueur;
    static public int niveauMap;

    static public bool possedePelle;

    static public int nombrePlanches;
    static public int nombreTissus;
    static public int nombreCailloux;

    static public int nombrePlanchesNecessaires;
    static public int nombreTissusNecessaires;
    static public int nombreCaillouxNecessaires;

    static public Collectible creusable;
    static public bool affichemap;

    public Texture2D imagePlanches;
    public Texture2D imageTissus;
    public Texture2D imageCailloux;

    public Texture2D fullMap;
    public Texture2D map1;
    public Texture2D map2;
    public Texture2D map3;

    // Start is called before the first frame update
    void Start(){
        nombrePlanches = 0;
        nombreTissus = 0;
        nombreCailloux = 0;

        niveauJoueur = 0;
        possedePelle=false;
        creusable =null;

        nombrePlanchesNecessaires = 5;
        nombreTissusNecessaires = 0;
        nombreCaillouxNecessaires = 0;

        niveauMap=0;
        affichemap=false;
        }

    // Update is called once per frame
    void Update()
    {
        if(nombrePlanches >= 5 && niveauJoueur == 0){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            niveauJoueur+=1;
            PlayerMovement.increaseLevel();
            nombrePlanchesNecessaires = 2;
            nombreTissusNecessaires = 1;
        }

        if(nombrePlanches >= 2 && nombreTissus >= 1  && niveauJoueur == 1){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            nombreTissus = nombreTissus - nombreTissusNecessaires;
            niveauJoueur+=1;
            PlayerMovement.increaseLevel();
            nombrePlanchesNecessaires = 4;
            nombreTissusNecessaires = 8;
        }

        if(nombrePlanches >= 4 && nombreTissus >= 8  && niveauJoueur == 2){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            nombreTissus = nombreTissus - nombreTissusNecessaires;
            niveauJoueur+=1;
            PlayerMovement.increaseLevel();
            nombrePlanchesNecessaires = 2;
            nombreTissusNecessaires = 2;
            nombreCaillouxNecessaires = 10;
        }

        if(nombrePlanches >= 2 && nombreTissus >= 2 && nombreCailloux >= 10 && niveauJoueur == 3){
            nombrePlanches = nombrePlanches - nombrePlanchesNecessaires;
            nombreTissus = nombreTissus - nombreTissusNecessaires;
            nombreCailloux = nombreCailloux - nombreCaillouxNecessaires;
            niveauJoueur+=1;
            PlayerMovement.increaseLevel();
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

         if(affichemap){
            if(niveauMap==0){
                GUI.Label(new Rect(200, 50, fullMap.width/3, fullMap.height/3), fullMap);
            }
            else if(niveauMap==1){
                GUI.Label(new Rect(200, 50, fullMap.width/3, fullMap.height/3), fullMap);
                GUI.Label(new Rect(200, 50, map1.width/3, map1.height/3), map1);
            }
            else if(niveauMap==2){
                GUI.Label(new Rect(200, 50, fullMap.width/3, fullMap.height/3), fullMap);
                GUI.Label(new Rect(200, 50, map1.width/3, map1.height/3), map1);
                GUI.Label(new Rect(200, 50, map2.width/3, map2.height/3), map2);
            }
            else if(niveauMap==3){
                GUI.Label(new Rect(200, 50, fullMap.width/3, fullMap.height/3), fullMap);
                GUI.Label(new Rect(200, 50, map1.width/3, map1.height/3), map1);
                GUI.Label(new Rect(200, 50, map2.width/3, map2.height/3), map2);
                GUI.Label(new Rect(200, 50, map3.width/3, map3.height/3), map3);
            }
            
                
                
                
         }


         if (affichemap && GUI.Button (new Rect (Screen.width-100, Screen.height-40, 80, 20), "Carte")) {
            affichemap=false;
            }else if(!affichemap && GUI.Button (new Rect (Screen.width-100, Screen.height-40, 80, 20), "Carte")){
                affichemap=true;
            }

         if(creusable!=null){
             if (GUI.Button (new Rect (Screen.width/2-40, Screen.height/2-10, 80, 20), "Creuser")) {
                creusable.creuser();
            }
         }
    }

    public static void increaseNombrePlanches(){nombrePlanches=nombrePlanches+1;}
    public static void increaseNombreTissus(){nombreTissus=nombreTissus+1;}
    public static void increaseNombreCailloux(){nombreCailloux=nombreCailloux+1;}
    public static void increaseMap(){niveauMap=niveauMap+1;}
    public static void recuperePelle(){possedePelle=true;}

    public static void afficheCreuser(Collectible collectible){
        if(possedePelle){
        creusable=collectible;}
    }
}