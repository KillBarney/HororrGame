using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FollowGhost : MonoBehaviour
{

    NavMeshAgent nav;
    GameObject target;
   
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Playerbody");
    }

    // Update is called once per frame
    void Update()
    {
        if (nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //GameObject.Find("GameObject").transform.Find("Ghost");
            SceneManager.LoadScene("Death");
            
        }
    }
}