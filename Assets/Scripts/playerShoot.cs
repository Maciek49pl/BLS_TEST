using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    //okre�lamy miejsce z kt�rego strzela� oraz prefab pocisku
    public Transform firePoint;
    public GameObject bulletPrefab;

    //si�a pocisku
    public float bulletForce = 20f;

    void Update()
    {
        //Klikasz lewy przycisk myszy aby strzela�
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    //Funkcja odpowiadaj�ca za strzelanie
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
