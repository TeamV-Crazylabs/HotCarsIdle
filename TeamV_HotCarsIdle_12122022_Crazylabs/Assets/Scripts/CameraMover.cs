using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMover : MonoBehaviour
{
    private float rotationSpeed = 0.5f;

    public static bool DebugMode = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1 && !EventSystem.current.IsPointerOverGameObject())
        {
            Touch screenTouch = Input.GetTouch(0);

            if (screenTouch.phase == TouchPhase.Moved)
            {
                transform.Rotate(0f, screenTouch.deltaPosition.x * rotationSpeed, 0f);
                
            }

        }

        if (DebugMode)
        {
            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);

                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, screenTouch.deltaPosition.x * rotationSpeed, 0f);

                    transform.Rotate(screenTouch.deltaPosition.y * rotationSpeed * -1, 0f, 0f);
                }

            }
        }
    }
}
