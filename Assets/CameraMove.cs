using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    float speed;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0012f;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= 24)
        {
            if (speed <= 0.0024f)
            {
                speed += 0.0001f;
                timer = 12;
            }
        }
        Camera.main.transform.position = Camera.main.transform.position + new Vector3(0, speed, 0);
    }
}
