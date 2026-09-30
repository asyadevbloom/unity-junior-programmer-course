using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;

    public float spawnCooldown = 1.0f;
    private float nextSpawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (fireAction.triggered)
        {
            if (Time.time > nextSpawnTime)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                nextSpawnTime = Time.time + spawnCooldown;
            }
        }
    }
}
