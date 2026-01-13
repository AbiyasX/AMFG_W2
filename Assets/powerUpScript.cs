using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public float pickupDistance = 1.5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance <= pickupDistance)
        {
            PlayerShoot.instance.addBullet();
            Destroy(gameObject);
        }
    }
}
