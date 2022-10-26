using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject platform;
    float timer;
    float height, position;
    Vector3 spawn;

    // Start is called before the first frame update
    void Start()
    {
        height = -4;
        position = 0;
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn , Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f,2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
        height += Random.Range(0.75f, 1.5f);
        position = Random.Range(-2f, 2f);
        spawn = new Vector3(position, height, 0);
        Instantiate(platform, spawn, Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            timer = 0;
            height += Random.Range(0.75f, 1.5f);
            position = Random.Range(-2f, 2f);
            spawn = new Vector3(position, height, 0);
            Instantiate(platform, spawn, Quaternion.identity);
        }
    }
}
