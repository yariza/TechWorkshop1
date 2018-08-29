using UnityEngine;

public class FollowTarget : MonoBehaviour {

    [SerializeField]
    Transform target;

    [SerializeField]
    Vector3 offset = new Vector3(0, 3, -5);

    [SerializeField]
    float lookDownAngle = 15;

    [SerializeField, Range(0, 3)]
    float lerpFactor = 5;

	// Use this for initialization
    void Start() {
        
    }

	// Update is called once per frame
    void Update() {
        // transform.position = target.position + offset;
        // transform.rotation = Quaternion.Euler(lookDownAngle, 0, 0);

        Vector3 cameraTarget = target.position + offset;
        transform.position = Vector3.LerpUnclamped(transform.position, cameraTarget, lerpFactor);
        transform.rotation = Quaternion.Euler(lookDownAngle, 0, 0);
    }
}