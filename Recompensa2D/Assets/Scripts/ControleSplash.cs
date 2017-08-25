using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleSplash : MonoBehaviour
{
    public float timer = 3f;
    public string nomeDaCena = "Menu";

    void Start()
    {
        Invoke("FimDoSplash", timer);


    }

    void FimDoSplash()
    {
        // GameManager.Instance.GetComponent<SceneManager>().CarregarCena(nomeDaCena);
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomeDaCena);
    }

}
