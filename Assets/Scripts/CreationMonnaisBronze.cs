using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaisBronze : MonoBehaviour
{
    
    [SerializeField] GameObject _prefabOriginal;
    
    void Start()
    {
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_prefabOriginal, _prefabOriginal.transform.position, _rotation);
    }
}
