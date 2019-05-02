using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMotor : MonoBehaviour
{
    public Vector3 targetPosition;
    public NavMeshAgent agent;
    public float agentSpeed = 3.5F;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = agentSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(cameraRay, out hit))
            {
                targetPosition = new Vector3(hit.point.x, 0, hit.point.z);
            }
        }

        agent.destination = targetPosition;
    }
}
