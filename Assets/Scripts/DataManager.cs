using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    [SerializeField] private InputField nameInputField;
    [SerializeField] private Button startButton;

    [HideInInspector] public string UserName;

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

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void NameChanged(string newName)
    {
        UserName = nameInputField.text;

        startButton.interactable = UserName != null && UserName != "";
    }
}
