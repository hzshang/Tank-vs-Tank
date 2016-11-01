using UnityEngine;

public class UIDirectionControl : MonoBehaviour
{
    private Quaternion parentRocation;
    public bool isRealitiveRotation=true;
    private void Start()
    {
        parentRocation = transform.parent.localRotation;
    }


    private void Update()
    {
        if (isRealitiveRotation)
            transform.rotation = parentRocation;
    }
}
