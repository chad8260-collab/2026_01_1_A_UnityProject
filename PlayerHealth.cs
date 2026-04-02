using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentLives = maxLives;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            currentLives--;
            Destroy(other.gameObject);

            if(currentLives <= 0)
            {
                Gameover();
            }
        }
    }
void Gameover()
    {
        gameObject.SetActive(false);
        Invoke("RestartGame", 3.0f);
    }
void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
