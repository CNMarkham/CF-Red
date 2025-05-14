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

        GameObject closestObject = null;
        float minDistance = Mathf.Infinity;
        
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("obstacles"))
        {
            float distance = Vector3.Distance(go.transform.position, transform.position);
            if (distance < minDistance)
            {
                closestObject = go;
                minDistance = distance;
            }
        }

        agent.destination = closestObject.transform.position;

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
