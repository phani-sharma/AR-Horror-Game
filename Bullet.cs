using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    float speed = 15f;
    public Rigidbody rigB;

    private int killCount = 0;
    public Text points;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        rigB.velocity = transform.forward * speed;
    }
    void OnTriggerEnter(Collider collideInfo)
    {
        if (collideInfo.gameObject.tag.Equals("Enemy"))
        {
            killCount++;
            points.text = (killCount * 4).ToString()+" " +"Points";
            Destroy(collideInfo.gameObject);
            Destroy(gameObject);
        }
    }
   
}

