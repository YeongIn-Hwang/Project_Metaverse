using UnityEngine;

public class flow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        transform.position = target.position + offset;
        
    }
}
