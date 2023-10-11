using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public Text timeText;
    private float time;


    // Start is called before the first frame update
    private void Awake()
    {
        time = 200f;
    }
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;

          if (time <= 0)
            {
                GameObject.Find("Playerbody").transform.Find("Light").gameObject.SetActive(false);

            }
        }



        timeText.text = Mathf.Ceil(time).ToString();

    }
    
}
