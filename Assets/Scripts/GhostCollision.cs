using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ghost"))
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
        // Reinicia el nivel
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
