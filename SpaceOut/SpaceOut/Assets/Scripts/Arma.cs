using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform PontoBala;
    public GameObject BalaPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparo();
        }
    }
    
    void Disparo()
    {
        Instantiate(BalaPrefab, PontoBala.position, PontoBala.rotation);
    }
}
