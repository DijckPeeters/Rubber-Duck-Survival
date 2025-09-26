using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Test");
    }

    // Update is called once per frame
    void Update()
    {
        if(InputController.instance.Jump())
        {
            Debug.Log("Jump Key Pressed");
        }
    }
}
