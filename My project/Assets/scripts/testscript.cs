using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //Transform myTr = gameObject.GetComponent<Transform>();
        //Debug.Log(myTr.position);
        //Debug.Log(myTr.rotation);
        //Debug.Log(myTr.localScale);
        //var component = gameObject.AddComponent<SphereCollider>();
        //gameObject.GetComponent<Transform>().rotation = Quaternion.Euler(0f, 45f, 0f);
       

    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move * 3 * Time.deltaTime, 0f, 0f);

        float move1 = Input.GetAxis("Vertical");
        transform.position += new Vector3(move1 * 3 * 0f, Time.deltaTime, 0f);
    }
}
