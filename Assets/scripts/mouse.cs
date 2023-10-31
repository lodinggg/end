using UnityEngine;

public class mouse : MonoBehaviour
{
    private float speed = 1f;

    void Update()
    {
        transform.Rotate(0f, -Input.GetAxis("Mouse X") * speed, 0f, Space.Self);
        transform.Rotate(-Input.GetAxis("Mouse Y") * speed, 0f, 0f);
    }
}
