using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_scene : MonoBehaviour
{
    public void load_s(string name_scene)
    {
        SceneManager.LoadScene(name_scene);
    }
}
