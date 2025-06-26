using UnityEngine;

public class followCamera : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position + offset;
    }
}
