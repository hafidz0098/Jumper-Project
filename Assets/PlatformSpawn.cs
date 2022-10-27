using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject platform;
    float timer;
    float height, position;
    float speed;
    float camHeight;
    Vector3 spawn;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0012f;
        camHeight = -4;
        height = -4;
        position = 0;
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn , Quaternion.identity);
        height += Random.Range(1.5f, 2.5f);
        position = Random.Range(-2f,2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(1.5f, 2.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(1.5f, 2.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(1.5f, 2.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(1.5f, 2.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(1.5f, 2.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(1.5f, 2.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
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
        camHeight += speed;
        if (height <= camHeight + 11)
        {
            height += Random.Range(1.5f, 2.5f);
            position = Random.Range(-2f, 2f);
            spawn = new Vector3(position, height, 0);
            Instantiate(platform, spawn, Quaternion.identity);
        }
    }
}
