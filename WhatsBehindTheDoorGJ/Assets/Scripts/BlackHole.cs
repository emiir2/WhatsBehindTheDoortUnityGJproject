using UnityEngine;

public class BlackHole : MonoBehaviour
{

    public Transform player;
    Rigidbody playerBody;

    public float influenceRange;
    public float intensity;

    public float distanceToPlayer;
    Vector3 pullForce;

    void Start()
    {
        playerBody = player.GetComponent<Rigidbody>();
    }

    void Update()
    {

        distanceToPlayer = Vector3.Distance(player.position, transform.position);
        if (distanceToPlayer <= influenceRange)
        {
            pullForce = (transform.position - player.position).normalized / distanceToPlayer * intensity;
            playerBody.AddForce(pullForce, ForceMode.Force);
        }
    }
}
