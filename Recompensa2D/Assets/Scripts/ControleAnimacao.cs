using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ControleAnimacao : MonoBehaviour
{
    public Animator anim;
    private bool estado,encontrada;
    public GameObject handle;


    public void StartClick ()
    {
        encontrada = handle.GetComponent<DefaultTrackableEventHandler>().GetGetimagemEncontra();
        if (encontrada)
        {
            estado = true;
        }
        MudarEstado(estado);

    }

    public void PauseClick()
    {
        estado = false;
        MudarEstado(estado);
    }

    private void MudarEstado(bool estado)
    {
        anim.SetBool("Estado", estado);
    }

}
