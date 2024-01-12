using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEditor.SearchService;



public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public TMP_InputField inputField;
    public TMP_Dropdown dropdown;

    public static string nombreJugador;
    public static int numPersonaje;
    


    private void Update()
    {
        BuscarObjetos();     


    }

    void BuscarObjetos()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            inputField = FindAnyObjectByType<TMP_InputField>();
            dropdown = FindAnyObjectByType<TMP_Dropdown>();

            nombreJugador = inputField.text;
            numPersonaje = dropdown.value;

        }
    }


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
       
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

}
