using UnityEngine;
using System.Collections;

public class FireHandSpwanerInteractable : MonoBehaviour
{
    private bool isSelected = false;
    [SerializeField]
    private GameObject WorldState;

    [SerializeField]
    private float stayToObtainTime = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "Left Collider" || collision.gameObject.name == "Right Controller" ) && !isSelected)
        {
            isSelected = true;
            //Debug.Log("Fire Hand Obtained");
            WorldState.GetComponent<WorldState>().fireHandObtantion();
            Destroy(gameObject);
        }
    }

    IEnumerator FireHandObtantionRoutine()//for now this is not used
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(stayToObtainTime);
        print("WaitAndPrint " + Time.time);
    }
}
