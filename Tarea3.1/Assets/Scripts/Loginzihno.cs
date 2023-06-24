using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using UnityEngine.SceneManagement;
using GameJolt.API;
using GameJolt.API.Objects;
public class Loginzihno : MonoBehaviour
{
    
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool signedIn) =>
        {
            if (signedIn)
            {
                SceneManager.LoadScene("Inicio");
            }

        });                
        
    }
}
