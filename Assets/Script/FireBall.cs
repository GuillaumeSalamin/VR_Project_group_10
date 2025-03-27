using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour
{
    private bool isFalling = false;
    private float fallingDelayTime = 3.0f;
    private bool hasFallen = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        StartCoroutine(fallingDelay());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (isFalling && !hasFallen)
        {
            hasFallen = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private IEnumerator fallingDelay()
    {
        yield return new WaitForSeconds(fallingDelayTime);
        isFalling = true;
    }
}
