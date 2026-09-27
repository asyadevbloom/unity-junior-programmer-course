using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 2.0f;

    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}
