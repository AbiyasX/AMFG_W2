using UnityEngine;

using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public static PlayerShoot instance;

    public GameObject bulletPrefab;
    public Transform firePoint;
    [Range(1,8)]
    public int bulletCount = 1; 

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        InvokeRepeating(nameof(Shoot), 1f, 4f);
    }

    public void addBullet()
    {
        bulletCount += 1;
    }

    void Shoot()
    {
        float angleStep = 360f / bulletCount;
        float startAngle = 0f;

        for (int i = 0; i < bulletCount; i++)
        {
            float angle = startAngle + angleStep * i;
            FireBullet(angle);
        }
    }

    void FireBullet(float angle)
    {
        Quaternion rot = Quaternion.Euler(0f, 0f, angle);
        Instantiate(bulletPrefab, firePoint.position, rot);
    }
}
