using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D Body; 
    // Start is called before the first frame update
    void Start()
    {
        Body.velocity = transform.up * speed; 
    }

    private void Update()
    {
        if (this.transform.position.y > 6)
        {
            Destroy(this.gameObject);
        }
    }

}
