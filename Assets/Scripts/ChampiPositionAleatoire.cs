using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampiPositionAleatoire : MonoBehaviour
{
    private Vector3 _positionDrapeau = new Vector3(2.61f, 1f, -4.365f);
    private Vector3 _positionCaisse = new Vector3(-1.248f, 1f, -4.365f);

    void Start()
    {
        
        float Aleatoire = Random.value(0f, 1f);

        if(Aleatoire > 0.5f) {

            transform.position = _positionDrapeau;

        }

        else {

            transform.position = _positionCaisse;
            
        }

    }

}
