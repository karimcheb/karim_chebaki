using UnityEngine;
using UnityEngine.UI;

public class MillisecondsTimer : MonoBehaviour
{
    public Text timerText;
    private float elapsedTime = 0f;

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        int milliseconds = Mathf.FloorToInt((elapsedTime * 1000) % 1000);

        string timeString = "Time: " + milliseconds.ToString("D3") + "ms";

        timerText.text = timeString;
    }
}
