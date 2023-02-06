using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenHu : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePointTrans;
    public float minShootForce;
    public float maxShootForce;

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
        bulletInstance.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0,Random.Range(minShootForce,maxShootForce)));
    }
}
