using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform obstacle;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        obstacle = GameObject.FindGameObjectWithTag("obstacles").transform;
        agent.destination = obstacle.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("obstacles"))
        {
            Destroy(collision.gameObject);
            Destroy(transform.gameObject);
        }
    }
}
