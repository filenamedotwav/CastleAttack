using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Animator scoreAnimator;
    public Text scoreDisplay;
    public Text numProj;
    public int threeStars = 2;
    public int twoStars = 4;
    public int nextLevel = 0;
    public void EndLevel()
    {
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;
            

            if (numProjectiles < threeStars)
            {
                print("Three Stars!");
                scoreDisplay.text = "Three Stars!";
                scoreAnimator.SetInteger("Stars", 3);
            }

            else if (numProjectiles < twoStars)
            {
                print("Two Stars");
                scoreDisplay.text = "Two Stars!";
                scoreAnimator.SetInteger("Stars", 2);
            }

            else
            {
                print("One Star");
                scoreDisplay.text = "One Star!";
                scoreAnimator.SetInteger("Stars", 1);
            }
            numProj.text = "Projectiles: " + numProjectiles;
            Invoke("NextLevel", 3); 
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
        
        
    }
}
