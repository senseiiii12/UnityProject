using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    CHscipt player;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
        player = GameObject.FindObjectOfType<CHscipt>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 1)
        {
            Destroy(gameObject);
        }
    }
}
