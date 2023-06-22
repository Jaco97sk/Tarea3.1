using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour
{
    public void butao(string nivel)
    {
        SceneManager.LoadScene(nivel);
    }
}
