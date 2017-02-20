using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere_1 : MonoBehaviour
{

    float t = 0;
    float x = 0;
    float y = 0;
    float z = 0;

    // Use this for initialization
    void Start() {
        x = transform.position.x;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update() {
        t = Time.deltaTime;
        y = 5 * Mathf.Sin(t);
        transform.position = new Vector3(x, y, z);
    }
}
