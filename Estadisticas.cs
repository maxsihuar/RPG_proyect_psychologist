using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Estadisticas : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Consecuencias ()
    {
        if (Npc_dialogue.Caso_tipo == 1)
        {
            if (Interfas.Ayuda_tipo == 3)
            {
                text.text = "Buen trabajo";

            }
            else
            {
                text.text = "Trataste pero no lolograste";
            }
        }
        if (Npc_dialogue.Caso_tipo == 2)
        {
            if (Interfas.Ayuda_tipo == 1)
            {
                text.text = "Buen trabajo";
                print("hola");
            }
            else
            {
                text.text = "Trataste pero no lolograste";
            }
        }
        if (Npc_dialogue.Caso_tipo == 3)
        {
            if (Interfas.Ayuda_tipo == 2)
            {
                text.text = "Buen trabajo";
            }
            else
            {
                text.text = "Trataste pero no lolograste";
            }
        }
    }
}
