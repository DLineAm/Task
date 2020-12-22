using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class test : MonoBehaviour
{
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(agent.SetDestination(new Vector3(mousePos.x, mousePos.y, 0)));
        }
    }
        
}
