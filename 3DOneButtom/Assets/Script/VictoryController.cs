using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryController : MonoBehaviour
{

    private bool gameWon = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WinningObject"))
        {
            gameWon = true;
            SceneManager.LoadScene("Victory");

        }
    }
}
