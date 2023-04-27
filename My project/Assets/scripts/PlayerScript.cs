using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject[] points;
    Vector3 _target;
    public float speed;
    public int _index;
    // Start is called before the first frame update
    void Start()
    {
        _target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            if(_index < points.Length - 1)
            {
                _index++;
                _target = points[_index].transform.position;
            }
            else
            {
                _index = 0;
            }
        }
        else if (Input.GetKeyDown("left"))
        {
            if(_index > 0)
            {
                _index--;
                _target = points[_index].transform.position;
            }
            else
            {
                _index = points.Length - 1;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, Time.deltaTime * speed);
        }
        Debug.Log(_index);

    }
}
