using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void goLeft()
    {
        Vector3 position = this.transform.position;
        position.x--;
        this.transform.position = position;
    }
    public void goRight()
    {
        Vector3 position = this.transform.position;
        position.x++;
        this.transform.position = position;
    }
    public void goUp()
    {
        Vector3 position = this.transform.position;
        position.y++;
        this.transform.position = position;
    }
    public void goDown()
    {
        Vector3 position = this.transform.position;
        position.y--;
        this.transform.position = position;
    }
}
