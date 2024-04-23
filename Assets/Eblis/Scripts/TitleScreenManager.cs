
using UnityEngine;
using System.Collections;

public class TitleScreenManager : MonoBehaviour
{
    [SerializeField] Color _fadeColor;
    [SerializeField] string _gameSceneName;
    float _fadeTime = 1;
    public void _StartGame()
    {
        //Debug.Log("Start");
        //StartCoroutine(_startGameRoutine());
        UnityEngine.SceneManagement.SceneManager.LoadScene(_gameSceneName);
    }
    IEnumerator _startGameRoutine()
    {
        Debug.Log("StartRoutin");
        Color newCol = _fadeColor;
        newCol.a = 0;
        while (newCol.a < 1f)
        {
            Debug.Log("StartRoutinLoop");
            newCol.a += _fadeTime * Time.deltaTime;
            yield return null;
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene(_gameSceneName);
    }
}
