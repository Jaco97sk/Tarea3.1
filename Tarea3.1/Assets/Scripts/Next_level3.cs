using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameJolt.API;
using GameJolt.API.Objects;
public class Next_level3 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Trophies.Get(197822, (Trophy trophy) =>
            {
                if (trophy != null)
                {
                    Trophies.TryUnlock(trophy, (TryUnlockResult result) =>
                    {
                        SceneManager.LoadScene("Victoria");
                        switch (result)
                        {
                            case TryUnlockResult.Unlocked:
                                Debug.Log("exito");
                                break;
                            case TryUnlockResult.AlreadyUnlocked:
                                Debug.Log("Dije exito");
                                break;
                            case TryUnlockResult.Failure:
                                Debug.Log("Terrible");
                                break;
                        }
                    });
                }
            });
        }
    }
}
