using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragNDrop : MonoBehaviour
{
    private bool dragging = false;
    private float zdist;
    Vector3 offset;
    private void OnMouseDown()
    {
        // 
        Vector3 mousePos = Mouse.current.position.ReadValue();
        mousePos.z = 0f;
        Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);

        // 
        offset = transform.position - mousePosWorld;
        dragging = true;
    }
    private void Update()
    {
        if (dragging)
        {
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos.z = zdist;
            Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);

            // Aplicamos el movimiento sumando el offset original
            transform.position = mousePosWorld + offset;

            if (!Mouse.current.leftButton.isPressed)
            {
                dragging = false;
            }
        }
    }
}
