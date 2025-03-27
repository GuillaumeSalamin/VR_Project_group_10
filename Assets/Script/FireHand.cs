using UnityEngine;
using UnityEngine.XR; 
using UnityEngine.InputSystem;


public class FireHand : MonoBehaviour
{
    private Light fireLight;

    [SerializeField]
    private GameObject FireBall;

    private InputData _inputData;

    public InputActionReference triggerButton;
    public InputActionReference gripButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireLight = GetComponent<Light>();

        //_inputData = GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {

        if(triggerButton.action.triggered)
        {
            Debug.Log("Left Hand Triggered");
            Instantiate(FireBall, transform.position, transform.rotation);
        }
        if(gripButton.action.triggered)
        {
            Debug.Log("Left Hand grip");
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
        
    }
}
