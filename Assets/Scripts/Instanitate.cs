using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanitate : MonoBehaviour 
{
    [SerializeField] private GameObject Eagle;

    private WaitForSeconds _twoSeconds = new WaitForSeconds(2);
    private int _currentPoint = 0;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {      
        while (true)
        {
            GameObject newEagle = Instantiate(Eagle, transform.GetChild(_currentPoint).position, Quaternion.identity);
            _currentPoint++;

            if (_currentPoint == transform.childCount)
            {
                _currentPoint = 0;
            }
            yield return _twoSeconds;
        }
    }
}
