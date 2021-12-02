using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interfas : MonoBehaviour
{
    public GameObject Interfaz;
    public TMPro.TextMeshProUGUI text;
    public GameObject Player;
    int i = 0;
    private string Nombre;

    public static int Ayuda_tipo;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Nombre = Npc_dialogue.Nombre_global;

        if (i == 3)
        {
            Player.GetComponent<Estadisticas>().Consecuencias();
        }

        if (i >= 4)
        {  
            Interfaz.SetActive(false);
            float count=0;
            count += Time.deltaTime;

            if (count >= 3)
            {
                i = 0;
                count = 0;
            }
        }
    }

    public void Dialogar()
    {
        i++;
        if (i == 1)
        {
            text.text = "Yo  : "+"Crees que lo que hisite esta bien";
        }else if (i == 2)
        {
            text.text="Yo  : "+"Bueno, creo que ya hablamos mucho";
        }
        Ayuda_tipo = 1;
    }
    
    public void Escuchar()
    {
        i++;
        if (i == 1)
        {
            text.text = Nombre+"  : "+"Bueno creo que tendria que pensarlo mejor, nooo lo crees";
        }
        if (i == 2)
        {
            text.text = Nombre+"  : "+"Es muy valioso para mi ayudame";
        }
        Ayuda_tipo = 2;
    }
    public void Ayuda()
    {
        Ayuda_tipo = 3;
    }
}
