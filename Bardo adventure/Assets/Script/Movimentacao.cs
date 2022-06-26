using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public Rigidbody rig;
    public Animator animAndar;
    public Animator puloAnim;

    public float velocidade;
    public float velpulo;
    public float veloRota;

    // Update is called once per frame
    void Update()
    {
        Move();
        pular();
    }

    void Move()
    {
        //andar de frente
         if(Input.GetKey("w"))
        {
             animAndar.SetBool("Andar",true);
        }else{
            animAndar.SetBool("Andar",false);
        }
        // andar esquerda
        if(Input.GetKey("a"))
        {
             animAndar.SetBool("AndarEsquerda",true);
            
        }else{
            animAndar.SetBool("AndarEsquerda",false);
        }
        // andar direita
        if(Input.GetKey("d"))
        {
             animAndar.SetBool("AndarDireita",true);
            
        }else{
            animAndar.SetBool("AndarDireita",false);
        }
        // andar de tras
        if(Input.GetKey("s"))
        {
             animAndar.SetBool("AndarTras",true);
            
        }else{
            animAndar.SetBool("AndarTras",false);
        }
        // fim do movimento

        float velo = Input.GetAxis("Mouse X")*veloRota;
        transform.Rotate(0,velo,0);
    }

    void pular()
    {
       if(Input.GetKey("space"))
       {
           puloAnim.SetBool("Pulo",true);
           rig.velocity = new Vector3(0,0,velpulo);
       }else{
          puloAnim.SetBool("Pulo",false);
       }
    }
}
