using UnityEngine;

public class CameraWorks : MonoBehaviour {

    public Transform horizontalRotNode;
    public Transform verticalRotNode;
    public Transform dollyNode;

    public const float DELTA_ANGLE = 1.0f;
    public const float DELTA_DOLLY = 0.05f;

    /**
     * 十字キーで回転 Z/Xキーでズーム
     */
    void Update () {
        RotateHorizontal();
        RotateVertical();
        Dolly();
    }

    private void RotateHorizontal()
    {
        float horizontalAngle = horizontalRotNode.localRotation.eulerAngles.y;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle + DELTA_ANGLE, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle - DELTA_ANGLE, 0));
        }
    }

    private void RotateVertical()
    {
        float verticalAngle = verticalRotNode.localRotation.eulerAngles.x;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle + DELTA_ANGLE, 0, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle - DELTA_ANGLE, 0, 0));
        }
    }

    private void Dolly()
    {
        if (Input.GetKey(KeyCode.X))
        {
            dollyNode.transform.localPosition += new Vector3(0, 0, DELTA_DOLLY);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            dollyNode.transform.localPosition -= new Vector3(0, 0, DELTA_DOLLY);
        }
    }
}