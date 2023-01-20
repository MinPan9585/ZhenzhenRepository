using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenHu : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePointTrans;
    public Vector3 shootForce;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject bulletInstance = Instantiate(bullet, firePointTrans.position, firePointTrans.rotation);
        bulletInstance.GetComponent<Rigidbody>().AddForce(shootForce);
    }
}
