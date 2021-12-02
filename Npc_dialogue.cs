using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Npc_dialogue : MonoBehaviour
{
    //Parte grafica
    public GameObject img;
    public TMPro.TextMeshProUGUI text;

    [Header("Dialogos custom")]
    [Space]
    [TextArea(1, 7)]
    [Tooltip("En este espacio puede escribir una historia el la cual definas a tus NPC y como resolverlo")]

    //Dialogos Custom
    public string dialogo;
    [Tooltip("Al marcar este espacio podras usar el dialogo custom")]
    public bool Dialgo_custom;

    [Header("Defina el sexo de NPC")]
    [Space]
    //Sexo
    public bool Hombre;
    public bool Mujer;

    [Space]
    //Nombres de los NPC
    string[] nombres_hombres = new string[6] { "Pedro", "Juan", "Miguel", "Jose", "Matias", "Ricardo" };
    string[] nombres_mujeres = new string[6] { "Maria", "Angela", "Rosa", "Isabella", "Emily", "Mia" };
    int indicador_hombre;
    int indicador_mujer;
    public static string Nombre_global;

    [Space]
    //Tipos de dialogos por defecto
    string Dialogo_1;
    string Dialogo_2;
    string Dialogo_3;
    int Selector;

    [Header("Mostrar nombre del NPC")]
    [Tooltip("Aqui podras definir si quieres que se vea el nombre del NPC, esta duncion requiere los parametros de un textMeshPro y un nuevo objeto hijo desactivado")]
    [Space]
    public bool Name;
    public GameObject Nambre_text;

    //Tipo de problema
    public enum Caso
    {
        Perdida, Conflicto, Problemas
    }
    [Header("Defina el problema que tendras que solucionar")]
    [Space]
    public Caso caso;
    public static int Caso_tipo;


    // Start is called before the first frame update
    void Start()
    {
        indicador_hombre = Random.Range(0, 6);
        indicador_mujer = Random.Range(0, 6);
        Selector = Random.Range(0,4);


    }

    // Update is called once per frame
    void Update()
    {
        if (caso == Caso.Perdida)
        {
            Perdida();
            Caso_tipo = 1;
        }
        else if (caso == Caso.Conflicto)
        {
            Conflicto();
            Caso_tipo = 2;
        }
        else if (caso == Caso.Problemas)
        {
            Problema();
            Caso_tipo = 3;
        }

        if (Hombre)
        {
            Nombre_global = nombres_hombres[indicador_hombre];
        }
        if (Mujer)
        {
            Nombre_global = nombres_mujeres[indicador_mujer];
        }

    }   


    public void Perdida()
    {
        if (Dialgo_custom == false)
        {
            if (Hombre)
            {
                switch (Selector) 
                {
                    case 1:
                        Dialogo_1 = nombres_hombres[indicador_hombre]+"   :  "+ "Hola mi nombre es"  + nombres_hombres[indicador_hombre] + " y reciente mente perdi un objeto de " + nombres_mujeres[indicador_mujer] + ", quisiera recuperarlo me podrias ayudar?";
                        break;
                    case 2:
                        Dialogo_2 = nombres_hombres[indicador_hombre] + "   :  " + "Hola mi nombre es " + nombres_hombres[indicador_hombre] + " y hace un tiempo perdi un reloj de " + nombres_mujeres[indicador_mujer] + ", podrias buscarlo por mi?";
                        break;
                    default:
                        Dialogo_3 = nombres_hombres[indicador_hombre] + "   :  " + "Hola mi nombre es " + nombres_hombres[indicador_hombre] + " sabes un dia me pedi prestado unas ropas de " + nombres_mujeres[indicador_mujer] + ", podrias ir a mi casa a recuperar las ropas?";
                        break;
                }   
            }
            if (Mujer)
            {
                switch (Selector)
                {
                    case 1:
                        Dialogo_1 = nombres_mujeres[indicador_mujer] + "   :  " + "Hola mi nombre es " + nombres_mujeres[indicador_mujer] + " y reciente mente perdi un objeto de " + nombres_hombres[indicador_hombre] + ", quisiera recuperarlo me podrias ayudar?";
                        break;
                    case 2:
                        Dialogo_2 = nombres_mujeres[indicador_mujer] + "   :  " +"Hola mi nombre es " + nombres_mujeres[indicador_mujer] + " y hace un tiempo perdi un reloj de " + nombres_hombres[indicador_hombre] + ", podrias buscarlo por mi?";
                        break;
                    default:
                        Dialogo_3 = nombres_mujeres[indicador_mujer] + "   :  " + "Hola mi nombre es " + nombres_mujeres[indicador_mujer] + " sabes un dia me pedi prestado unas ropas de " + nombres_hombres[indicador_hombre] + ", podrias ir a mi casa a recuperar las ropas?";
                        break;
                }
            }
        }
    }


    public void Conflicto()
    {
        if(Dialgo_custom == false)
        {
            if (Hombre)
            {
                switch (Selector)
                {
                    case 1:
                        Dialogo_1 = nombres_hombres[indicador_hombre] + "   :   " + "Hola mi nombre es " + nombres_hombres[indicador_hombre] + " y reciente tuve un conflicto con " + nombres_mujeres[indicador_mujer] + ", me podrias ayudar a resolverlo?";
                        break;
                    case 2:
                        Dialogo_2 = nombres_hombres[indicador_hombre] + "   :  " + "Hola mi nombre es " + nombres_hombres[indicador_hombre] + " y tuve una discucion con " + nombres_mujeres[indicador_mujer] + ", podrias hablar con ella";
                        break;
                    default:
                        Dialogo_3 = nombres_hombres[indicador_hombre] + "   :  " + "Hola mi nombre es " + nombres_hombres[indicador_hombre] + " sabes yo no me llevo bien con " + nombres_mujeres[indicador_mujer] + ", podrias decirlo lo que pienso sobre ella";
                        break;
                }   
            }
            if (Mujer)
            {
                switch (Selector)
                {
                    case 1:
                        Dialogo_1 = nombres_mujeres[indicador_mujer] + "   :  " + "Hola mi nombre es " + nombres_mujeres[indicador_mujer] + "y reciente tuve un conflicto con " + nombres_hombres[indicador_hombre] + ", me podrias ayudar a resolverlo?";
                        break;
                    case 2:
                        Dialogo_2 = nombres_mujeres[indicador_mujer] + "   :  " + "Hola mi nombre es " + nombres_mujeres[indicador_mujer] + " y tuve una discucion con " + nombres_hombres[indicador_hombre] + ", podrias hablar con el";
                        break;
                    default:
                        Dialogo_3 = nombres_mujeres[indicador_mujer] + "   :  " + "Hola mi nombre es " + nombres_mujeres[indicador_mujer] + " sabes yo no me llevo bien con " + nombres_hombres[indicador_hombre] + ", podrias decirlo lo que pienso sobre el";
                        break;
                } 
            }
        }
    }

    public void Problema()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        print(Selector);
        if (Name|| collision.gameObject.CompareTag("Player;"))
        {
            Nambre_text.SetActive(true);
            img.SetActive(true);
        }
        if (collision.CompareTag("Player")||Dialgo_custom==false)
        {
            switch (Selector)
            {
                case 1:
                    text.text = Dialogo_1;
                    break;
                case 2:
                    text.text = Dialogo_2;
                    break;
                default:
                    text.text = Dialogo_3;
                    break;
            }
        }
        else if (Dialgo_custom == true)
        {
            text.text = dialogo;
        }
    }
}
