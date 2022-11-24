using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
public class UI_Manager : MonoBehaviour
{
    [SerializeField] Button playBttn;
    [SerializeField] Button pauseBttn;
    [SerializeField] Button closeBttn;

    private void Start()
    {
        lockCursor();
        playBttn.onClick.AddListener(PlayScene);
        pauseBttn.onClick.AddListener(PauseScene);
        closeBttn.onClick.AddListener(QuitScene);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnlockCursor();
            Time.timeScale = 0f;
        }
    }
    void PlayScene()
    {
        Time.timeScale = 1f;
    }

    void PauseScene()
    {
        Time.timeScale = 0f;
    }

    void QuitScene()
    {
        Application.Quit();
    }

    public void lockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
