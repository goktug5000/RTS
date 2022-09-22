using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Citizens : MonoBehaviour
{
    public Camera cam;
    public GameObject cube;
    public NavMeshAgent agent;

    public bool selected,deneme;

    void Start()
    {
        
    }


    void movee()
    {
        RaycastHit hit;

        if (Input.GetMouseButton(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }

            //Debug.Log(Vector3.Distance(this.gameObject.transform.position, hit.point));
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            movee();
        }


    }
}
