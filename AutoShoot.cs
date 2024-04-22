using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float timeBetweenShooting = 0.5f; // Adjust as needed
    private float timeWhenAllowedNextShoot;
    public float projectileLifetime = 3f;

    void Start()
    {
        timeWhenAllowedNextShoot = Time.time;
    }

    void Update()
    {
        CheckIfShouldShoot();
    }

    void CheckIfShouldShoot()
    {
        if (Time.time >= timeWhenAllowedNextShoot)
        {
            Shoot();
            timeWhenAllowedNextShoot = Time.time + timeBetweenShooting;
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Destroy(projectile, projectileLifetime);
    }
}
