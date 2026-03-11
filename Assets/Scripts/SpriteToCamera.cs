using UnityEngine;

public class SpriteToCamera : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }
    void FixedUpdate()
    {
        
        Vector3 directionToCamera = mainCamera.transform.position - transform.position;
        
        if (directionToCamera != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(directionToCamera);
            
            float targetYRotation = targetRotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0, targetYRotation, 0);
        }
    }
}
