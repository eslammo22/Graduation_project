using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYECONTROLER : MonoBehaviour
{
    float mouseX;
    float mouseY;
    public float Sensitivity = 100f;
    public Transform Player;
    float rotation = 0f;
    public float mainangle = -90;
    public float maxangle = 90;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;
        rotation -= mouseY;
        rotation = Mathf.Clamp(rotation, mainangle, maxangle);
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);
        Player.Rotate(Vector3.up * mouseX);
    }
}
