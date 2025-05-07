using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();


        GameObject tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach(GameObject t in GameObject.FindGameObjectsWithTag("obstacles"))
        {
            float dist = Vector3.Distance(t.transform.position, currentPos);
            if(dist < minDist)
            {
                tMin = t;
                minDist = dist;
            }

        }

        agent.destination = tMin.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("obstacles"))
        {
            Destroy(collision.gameObject);
            Destroy(transform.gameObject);
        }
    }
}
