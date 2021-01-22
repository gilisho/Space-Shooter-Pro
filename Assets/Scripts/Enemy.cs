using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
[SerializeField]
private float _speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime); // move down at 4 meters per second
        if (transform.position.y < -5.4f){
            transform.position = new Vector3(Random.Range(-8f, 8f), 7f, transform.position.z);
        }
    }
}
