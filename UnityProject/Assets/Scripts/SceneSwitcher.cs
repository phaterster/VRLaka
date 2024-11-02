using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{


    public void changeScene(int id) {
        SceneManager.LoadScene(id);
    }

}
