using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveZombie : MonoBehaviour
    
{
    [SerializeField]
    Transform _destination;
    NavMeshAgent _Agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Agent = this.GetComponent<NavMeshAgent>();
        if (_Agent == null)
        {
            Debug.LogError("Not attached" + gameObject.name);
        }
        else
        {
            setDestination();
        }
    }
    private void setDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _Agent.SetDestination(targetVector);
        }
    }
}
