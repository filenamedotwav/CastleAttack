using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text lose;
    public int gameOverScreen = 5;
    public int goal = 3;
    public GameObject explosion;

    void Update()
    {
        gameOver();
    }

    public void gameOver()
    {
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;
            if (numProjectiles > goal)
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
                lose.text = "You Lost!";
                Transition();
            }
        }
    }

    public void Transition()
    {
        SceneManager.LoadScene(gameOverScreen);
    }
}
