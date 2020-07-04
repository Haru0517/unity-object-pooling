using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = Vector3.zero;
        }
    }
}
