using UnityEngine;

public class CherryCollector : MonoBehaviour
{
    private int cherriesCollected = 0;
    public int totalCherries = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cherry"))
        {
            Destroy(other.gameObject);
            cherriesCollected++;
            if (cherriesCollected >= totalCherries)
            {
                WinGame();
            }
        }
    }

    void WinGame()
    {
        GameObject[] ghosts = GameObject.FindGameObjectsWithTag("Ghost");
        foreach (GameObject ghost in ghosts)
        {
            Destroy(ghost);
        }

        Debug.Log("¡Has ganado el juego!");
        
    }
}
