using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlaJogador : MonoBehaviour
{
    public float Velocidade = 10;
    public GameObject SpritePlayer;

    void Start()
    {

    }

    void Update()
    {

        // esquerda

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            //SpritePlayer.GetComponent<Animator>().Play("esq");
        }
        if (Keyboard.current.aKey.IsPressed())
        {
            this.transform.Translate(-Velocidade * Time.deltaTime, 0, 0);
        }

        // direita

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            //SpritePlayer.GetComponent<Animator>().Play("dir");
        }

        if (Keyboard.current.dKey.IsPressed())
        {
            this.transform.Translate(+Velocidade * Time.deltaTime, 0, 0);
        }

        /*
        // cima
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            SpritePlayer.GetComponent<Animator>().Play("cima");
        }
        if (Keyboard.current.wKey.IsPressed())
        {
            this.transform.Translate(0, +Velocidade * Time.deltaTime, 0);
        }

        // baixo
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            SpritePlayer.GetComponent<Animator>().Play("baixo");
        }

        if (Keyboard.current.sKey.IsPressed())
        {
            this.transform.Translate(0, -Velocidade * Time.deltaTime, 0);
        }
        */

    }
}
