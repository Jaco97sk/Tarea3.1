using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.API;
using GameJolt.API.Objects;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        Trophies.Get(197820, (Trophy trophy) =>
        {
            if (trophy != null)
            {
                Trophies.TryUnlock(trophy, (TryUnlockResult result) =>
                {
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

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
