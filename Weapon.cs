using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //Shoot();
    }
    public void Shoot()
    {
        //The shooting Logic
        Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
    }
}
