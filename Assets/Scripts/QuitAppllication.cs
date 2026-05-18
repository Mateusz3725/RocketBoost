using UnityEngine;
using UnityEngine.InputSystem;

public class QuitAppllication : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("Escape");
            Application.Quit();
        }
    }
}
