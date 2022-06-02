using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLength = 4f;

    public void Update()
    {
        //if (Input.GetKeyUp(KeyCode.X))
        //{
        //    Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
        //    Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        //}
        Time.timeScale += (1f / slowdownLength)* Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void DoSlowmotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.2f;
    }
    
}
