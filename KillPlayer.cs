using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
    public Text Info;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collideInfo)
    {
        if (collideInfo.gameObject.tag.Equals("Enemy"))
        {
            Destroy(gameObject);
            Info.gameObject.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}
