using UnityEngine;

public class WorldState : MonoBehaviour
{
    [SerializeField]
    public bool fireHandObtained = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fireHandObtantion(){
        Debug.Log("Fire Hand Obtained");
        fireHandObtained = true;
    }
}
