using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Transform temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Player")
        {
            
            GameObject.Find("GameObject").transform.Find("Ghost").gameObject.SetActive(true);
        }


    }

}
