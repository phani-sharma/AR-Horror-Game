using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenZombie : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Zombie2;
    public GameObject Zombie3;

    public int xpos;
    public int ypos;
    public int objectToGenerate;
    public int objectQuantity;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateObjects());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GenerateObjects()
    {
        while (objectQuantity < 100)
        {
            objectToGenerate = Random.Range(1, 4);
            xpos = Random.Range(-9, 6);
         

            if (objectToGenerate == 1)
            {
                Instantiate(Zombie, new Vector3(xpos, -2, 20), Quaternion.identity);
            }
            if (objectToGenerate == 2)
            {
                Instantiate(Zombie2, new Vector3(xpos, -2, 20), Quaternion.identity);
            }
            if (objectToGenerate == 3)
            {
                Instantiate(Zombie3, new Vector3(xpos, -2, 20), Quaternion.identity);
            }

            yield return new WaitForSeconds(0.5f);
            objectQuantity += 1;
        }
    }
}
