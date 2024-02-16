using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectsion : MonoBehaviour
{
    public WaeaponController wp;
    public GameObject HitParticle;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag == "Enemy");
        other.GetComponent<Animator>().SetTrigger("Hit");

    }
}
