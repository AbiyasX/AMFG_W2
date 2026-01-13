using UnityEngine;

public class bullet : MonoBehaviour
{
    
    void Start()
    {
        float startAngle = transform.eulerAngles.z;
    }

    void Update()
    {
        transform.position += transform.right * 20 * Time.deltaTime;
    }
}
