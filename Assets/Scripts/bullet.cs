using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Update()
    {
        //nie trafiony pocisk po czasie znika w imiê oszczêdzania pamiêci
        if (transform.position.x > 20)
        {
            Destroy(gameObject);
        }
    }
}
