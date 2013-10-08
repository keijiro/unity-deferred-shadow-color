using UnityEngine;
using System.Collections;

public class Jiggle : MonoBehaviour
{
    public float amount = 5.0f;
    public float freq = 0.5f;

    Quaternion initialRotation;
    float offset1;
    float offset2;

    void Awake ()
    {
        initialRotation = transform.localRotation;
        offset1 = Random.value * 100.0f;
        offset2 = Random.value * 100.0f;
    }

    void Update ()
    {
        transform.localRotation =
            Quaternion.AngleAxis (amount * (Mathf.PerlinNoise (Time.time * freq + offset2, 0.0f) - 0.5f), Vector3.right) *
            Quaternion.AngleAxis (amount * (Mathf.PerlinNoise (Time.time * freq + offset1, 0.0f) - 0.5f), Vector3.up) *
            initialRotation;
    }
}