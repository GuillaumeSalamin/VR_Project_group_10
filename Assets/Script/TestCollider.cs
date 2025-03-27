using UnityEngine;

public class TestCollider : MonoBehaviour
{
    private bool isSelected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision coll)
    {
        if ((coll.gameObject.name == "Left Collider" || coll.gameObject.name == "Right Controller" ) && !isSelected)
        {
            isSelected = true;
            Debug.Log("Fire Hand Obtained");
            
        }
    }
}
