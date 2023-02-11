using UnityEngine;


public class MoveWithMouse : MonoBehaviour
{
    // Start is called before the first frame update    
    void Start() { }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 fieldPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            transform.position = fieldPos;
        }
    }
}