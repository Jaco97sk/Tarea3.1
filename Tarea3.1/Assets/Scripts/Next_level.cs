using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_level : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel 2");
        }
    }

}
