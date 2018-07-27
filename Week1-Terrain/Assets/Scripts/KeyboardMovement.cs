using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{

	//public float rotateSensitivity;
	//public float moveSensitivity;

    void Update()
    {
        float yRotate = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 50.0f;
        float zMove = Input.GetAxisRaw("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, yRotate, 0);
        transform.Translate(0, 0, zMove);
    }
}