using UnityEngine;

public class playerScript : MonoBehaviour
{
    float horizontal, vertical;
    [SerializeField] float speed;
    Rigidbody rb;
    GameObject gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.FindGameObjectWithTag("GameManagerTag");
    }

    // Update is called once per frame
    void Update()
    {
        playerMov();
    }

    void playerMov()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 move=new Vector3 (horizontal, 0, vertical);
        rb.AddForce (move*speed,ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="pickable")
        {
            Destroy(other.gameObject);
            gameManager.GetComponent<gameManagerScript>().addScore();
        }
    }
}
