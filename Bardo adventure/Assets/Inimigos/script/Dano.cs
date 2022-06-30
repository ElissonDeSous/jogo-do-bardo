using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dano : MonoBehaviour
{
    public Slider  vidaPlayer;
   private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player"){
            vidaPlayer.value--;
        }
    }
}
