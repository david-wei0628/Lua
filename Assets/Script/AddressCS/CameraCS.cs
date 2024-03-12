using UnityEngine;

public class CameraCS : MonoBehaviour
{
    float MoveSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = Vector3.zero;
        this.gameObject.transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Camera_Move();
        }
    }

    void Camera_Move()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            //this.transform.position += new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, 0, Input.GetAxis("Vertical") * MoveSpeed);
            this.transform.Translate(Input.GetAxis("Horizontal") * MoveSpeed, 0, Input.GetAxis("Vertical") * MoveSpeed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(0, MoveSpeed * 0.05f, 0);
        }
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.Translate(0, -MoveSpeed * 0.05f, 0);
        }
    }
}
