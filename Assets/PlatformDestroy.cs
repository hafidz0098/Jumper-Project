using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : MonoBehaviour
{
    float timer;
    bool onScreen;
    // Start is called before the first frame update
    void Start()
    {
        onScreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 35)
        {
            Destroy(gameObject);
        }
    }

    void OnBecameVisible()
    {
        onScreen = true;
    }

    void OnBecameInvisible()
    {
        if(onScreen)
            Destroy(gameObject);
    }
}
