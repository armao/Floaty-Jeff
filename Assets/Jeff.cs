using UnityEngine;

public class Jeff : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    [SerializeField]
    private float force = 10;
    private bool jeffG = true;
    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {
        if (jeffG && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * force ;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
    jeffG = false;
            gameManager.GameOver();
        }
        

    }

}
