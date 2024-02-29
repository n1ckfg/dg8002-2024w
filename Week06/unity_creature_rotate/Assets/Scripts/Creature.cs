using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{

    public TargetGen targetGen;
    public float speed = 0.005f;
    public float shake = 0.03f;
    public float odds = 0.001f;
    public float rotationSpeed = 0.2f;

    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        setTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0f, 1f) < odds) setTarget();
        transform.position = Vector3.Lerp(transform.position, target.position, speed);
        
        float x = Random.Range(-shake, shake);
        float y = Random.Range(-shake, shake);
        float z = Random.Range(-shake, shake);
        transform.Translate(x, y, z);

        Vector3 direction = target.position - transform.position;
        Quaternion rotationToTarget = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationSpeed);
    }

    void setTarget() {
        int index = (int) Random.Range(0f, targetGen.targets.Count);
        Debug.Log(index);
        target = targetGen.targets[index].transform;
    }
}
