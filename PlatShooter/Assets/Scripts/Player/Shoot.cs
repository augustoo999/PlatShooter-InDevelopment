using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Projetil;
    public Transform Arma;
    private bool Tiro;
    public float ForcaTiro;
    private float FlipX;

    void Start()
    {
        
    }

    private void Attack()
    {
        if (Tiro == true)
        {
            GameObject tempShoot = Instantiate(Projetil);
            tempShoot.transform.position = Arma.position;
            tempShoot.GetComponent<Rigidbody2D>().velocity =  new Vector2 (ForcaTiro, 0);
            Destroy(tempShoot.gameObject, 3);
        }
    }

    void Update()
    {
        Tiro = Input.GetButtonDown("Fire1");
        Attack();
    }
}
