using UnityEngine;

public class GoalMiddle : MonoBehaviour
{
    public GameManager gameManager;
    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            gameManager.AddScore();
        }

    }


}
