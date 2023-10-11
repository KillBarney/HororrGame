using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IteamCount : MonoBehaviour
{
    int count = 0;
    //int count2 = 0;

    // Start is called before the first frame update
    public Text countText;
    //public Text countText2;
    void Start()
    {
        countText.text = "자료조사를 위해 찾아야할 아이템: 6/ " + count;
        //countText2.text = "탈출를 위해 찾아야할 아이템: 1/ " + count2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "자료조사를 위해 찾아야할 아이템: 6/ " + count;
        }
        //if (other.gameObject.CompareTag("Bar"))
        //{
        //    other.gameObject.SetActive(false);
        //    count2 = count2 + 1;
        //    countText2.text = "탈출를 위해 찾아야할 아이템: 1/ " + count2;
        //}
    }
}
