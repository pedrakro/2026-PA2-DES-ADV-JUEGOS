using UnityEngine;
using UnityEngine.SceneManagement;

public class scripbotones : MonoBehaviour
{
    
    public void Jugar()
    {
        SceneManager.LoadScene("LevelTutorial");
    }

    
    public void Salir()
    {
        Application.Quit();

        // Solo para probar en el editor
        Debug.Log("Juego cerrado");
    }
}