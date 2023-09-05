using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += Teleport; // โยง function ให้ทำงานพร้อมกัน
    }

    private void OnDisable()
    {
        EventManager.OnClicked -= Teleport; // ลบ function ที่ทำงานออกจาก OnClick
    }


    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
