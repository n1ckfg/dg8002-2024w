using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{

    public Transform target;
    public float speed = 0.01f;
    public float shake = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
        
        float x = Random.Range(-shake, shake);
        float y = Random.Range(-shake, shake);
        float z = Random.Range(-shake, shake);
        transform.Translate(x, y, z);
    }
}
