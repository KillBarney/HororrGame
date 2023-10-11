using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCount : MonoBehaviour
{
    int count2 = 0;
    public Text countText2;
    // Start is called before the first frame update
    void Start()
    {
        countText2.text = "탈출를 위해 찾아야할 아이템: 1/ " + count2;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bar"))
        {
            other.gameObject.SetActive(false);
            count2 = count2 + 1;
            countText2.text = "탈출를 위해 찾아야할 아이템: 1/ " + count2;
        }
    }
}
