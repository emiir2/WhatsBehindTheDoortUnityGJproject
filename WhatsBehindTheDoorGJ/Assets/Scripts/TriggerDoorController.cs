using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private Animator transition;
    [SerializeField] private float transitionTime = 2.5f;

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && openTrigger)
        {
            PlayDoorAnimation();
            gameObject.SetActive(false);
            Invoke(nameof(LoadNextLevel), transitionTime);
        }
    }

    private void PlayDoorAnimation()
    {
        myDoor.Play("DoorOpen", 0, 0.0f);
        transition.SetTrigger("Start");
    }
}
