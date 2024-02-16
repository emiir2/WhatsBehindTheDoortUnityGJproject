using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectsion : MonoBehaviour
{
    public WeaponController wc;
    public GameObject HitParticle;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && wc.IsAttacking)
        {
            Debug.Log(other.tag == "Enemy");
            other.GetComponent<Animator>().SetTrigger("Hit");
            Instantiate(HitParticle, new Vector3(other.transform.position.x,
            transform.position.y, other.transform.position.z),
            other.transform.rotation);


        }
        

    }
}
