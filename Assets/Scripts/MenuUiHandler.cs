using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUiHandler : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;
    public TMP_InputField nameInput;
    public TMP_Text bestScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        nameInput.text = GameManager.playerName;

        if (GameManager.score == -1)
        {
            bestScoreDisplay.gameObject.SetActive(false);
        }
        else {

            bestScoreDisplay.gameObject.SetActive(true);
        }

        if (GameManager.score >= GameManager.bestScore)
        {
            bestScoreDisplay.text = $"Best Score: {GameManager.score}";
        } else
        {
            bestScoreDisplay.text = $"Score: {GameManager.score}";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnNameValueChanged()
    {
        Debug.Log("Changed value: " + nameInput.text);
        if (nameInput.text.Length > 0)
        {
            startButton.interactable = true;
        }
        else
        {
            startButton.interactable = false;
        }
    }

    public void StartGame()
    {
        GameManager.playerName = nameInput.text;

        SceneManager.LoadScene("main");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
