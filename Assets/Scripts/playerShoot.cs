using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    //okreœlamy miejsce z którego strzelaæ oraz prefab pocisku
    public Transform firePoint;
    public GameObject bulletPrefab;

    //si³a pocisku
    public float bulletForce = 20f;

    void Update()
    {
        //Klikasz lewy przycisk myszy aby strzelaæ
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    //Funkcja odpowiadaj¹ca za strzelanie
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
