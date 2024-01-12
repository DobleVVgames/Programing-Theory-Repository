using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI nameP;
    
    
    void Start()
    {
        if (GameController.numPersonaje == 0)
        {
            nameP.text = $"{GameController.nombreJugador} : personaje: Perro";
        }
        else
        {
            nameP.text = $"{GameController.nombreJugador} : personaje: Gato";
        }

        
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

}
