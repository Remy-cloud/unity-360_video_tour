using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public CanvasGroup fadeCanvasGroup;
    public float fadeDuration = 1.0f;

    private bool isLoading = false;

    private void Start()
    {
        if (fadeCanvasGroup != null)
        {
            fadeCanvasGroup.alpha = 1f;
            StartCoroutine(FadeCanvas(1f, 0f));
        }
    }

    public void LoadSceneWithFade(string sceneName)
    {
        if (!isLoading)
        {
            StartCoroutine(LoadSceneRoutine(sceneName));
        }
    }

    private IEnumerator LoadSceneRoutine(string sceneName)
    {
        isLoading = true;

        if (fadeCanvasGroup != null)
        {
            yield return StartCoroutine(FadeCanvas(0f, 1f));
        }

        SceneManager.LoadScene(sceneName);
    }

    private IEnumerator FadeCanvas(float startAlpha, float endAlpha)
    {
        float elapsedTime = 0f;
        fadeCanvasGroup.alpha = startAlpha;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            fadeCanvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / fadeDuration);
            yield return null;
        }

        fadeCanvasGroup.alpha = endAlpha;
    }
}
