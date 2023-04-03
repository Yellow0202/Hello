using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float m_CameraMoveSpeed = 0.0f;

    private Transform Player_tr = null;
    Vector3 TargetPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Player_tr = GameObject.FindObjectOfType<PlayerManager>().transform;
        Player_tr = GameObject.FindObjectOfType<Player_Ctrl>().transform;
    }

    private void Update()
    {
        if (Player_tr == null)
            return;

        TargetPos = Player_tr.position;
        //TargetPos.y += 1.0f;
        TargetPos.z += -5.0f;

        //transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * m_CameraMoveSpeed);
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * m_CameraMoveSpeed);
    }
}
