using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject player;

    public float cameraEksenz;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInfo = player.transform.transform.position;

        mainCamera.transform.position = new Vector3(playerInfo.x, 0f, cameraEksenz);
    }
}
