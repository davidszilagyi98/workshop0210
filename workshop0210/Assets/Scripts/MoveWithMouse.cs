using UnityEngine;


public class MoveWithMouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get the point where the mouse was clicked
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10; // set the z position to 10
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Move the gameobject to the clicked position
            transform.position = worldPosition;
        }
    }
}