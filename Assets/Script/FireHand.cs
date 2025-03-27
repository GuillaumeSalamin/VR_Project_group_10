using UnityEngine;
using UnityEngine.XR; 
using UnityEngine.InputSystem;
using System.Collections;

public class FireHand : MonoBehaviour
{
    private Light fireLight;

    [SerializeField]
    private GameObject FireBall;
    [SerializeField] private float fallingDelayTime = 3.0f;
    [SerializeField] private Transform fireBallSpawnPoint;


    [SerializeField] private Transform fireHandPosition;

    public InputActionReference triggerButton;
    public InputActionReference gripButton;


    [SerializeField]
    private GameObject heatZone;

    private bool isHeating = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireLight = GetComponent<Light>();
        heatZone.SetActive(isHeating);
        //_inputData = GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {

        if(triggerButton.action.triggered)
        {
            Debug.Log("Left Hand Triggered");
            GameObject fireBallObj = Instantiate(FireBall, fireBallSpawnPoint.position, transform.rotation);
        }
        if(gripButton.action.triggered)
        {
            Debug.Log("Left Hand grip");
            isHeating = !isHeating;
            heatZone.SetActive(isHeating);
            if(fireLight.intensity <= 20)
            {
                fireLight.intensity = 30;
            }
            else
            {
                fireLight.intensity = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        if((transform.position -fireHandPosition.position).magnitude > 0.1)
        {
            transform.position = fireHandPosition.position;
        }
    }

    IEnumerator fallingDelay(GameObject fireBallObj)
    {
        yield return new WaitForSeconds(fallingDelayTime);
    }
}
