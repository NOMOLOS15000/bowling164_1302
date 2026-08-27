using UnityEditor.Build.Content;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public int point = 1;
    public bool hasFallen = false;

    

    void Update()
    {
        if (!hasFallen && Vector3.Angle(transform.up, Vector3.up) > 45f)
        {
            hasFallen = true;
            GameManager.instance.addpoint(point);
            this.gameObject.SetActive(false);
        }
    }
}
