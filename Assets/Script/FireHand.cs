using UnityEngine;
using UnityEngine.XR; 


public class FireHand : MonoBehaviour
{
    private GameObject leftHand;
    private GameObject rightHand;
    private Light fireLight;

    public InputDevice _leftController;
    public InputDevice _rightController;
    public InputDevice _HMD;

    private InputData _inputData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftHand = GameObject.Find("Left Collider");
        rightHand = GameObject.Find("Right Controller");
        fireLight = GetComponent<Light>();

        _inputData = GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {

        if (_inputData._leftController.TryGetFeatureValue(CommonUsages.primaryButton, out bool Abutton))
        {
            Debug.Log("A button: " + Abutton);
        }
        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 rightVelocity))
        {
            Debug.Log("B button: " + Bbutton);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
