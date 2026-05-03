using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public TMP_Text NamaPanel;

    public void SetNamaPanel(string nama)
    {
        NamaPanel.text = nama;
    }

    public void LoadScene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
