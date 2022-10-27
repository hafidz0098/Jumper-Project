using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayEvent : MonoBehaviour
{
    public void loadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
