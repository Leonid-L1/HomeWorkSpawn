using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCicle : MonoBehaviour
{
    private float _speed = 2.5f;
    private Vector3 _endPointPosition = new Vector3(0,7,0);
 
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPointPosition, _speed * Time.deltaTime);

        if(transform.position == _endPointPosition)
        {
            Destroy(gameObject);
        }      
    }
}
