using UnityEngine;

public class animationStateController : MonoBehaviour
{
    private Animator hostAnimator; // Reference to the Animator component

    private void Start()
    {
        // Get the Animator component attached to the host GameObject
        hostAnimator = GetComponent<Animator>();
    }

    // Method to play the greeting animation
    private void PlayGreetingAnimation()
    {
        // Trigger the "Greeting" animation if it exists
        hostAnimator.SetTrigger("greetingTrigger");
    }

    // Method to play the talking animation
    public void PlayTalkingAnimation()
    {
        // Trigger the "Talking" animation if it exists
        hostAnimator.SetTrigger("talkingTrigger");
    }

    // Method to play the idle animation
    public void PlayIdleAnimation()
    {
        // Trigger the "Idle" animation if it exists
        hostAnimator.SetTrigger("idleTrigger");
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
    
        if (other.CompareTag("Ch33_nonPBR"))
        {
            // Play the greeting animation when the player enters the trigger zone
            PlayGreetingAnimation();
        }
    }

    // OnTriggerExit is called when the Collider other exits the trigger
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Ch33_nonPBR"))
        {
            // Play the idle animation when the player exits the trigger zone
            PlayIdleAnimation();
        }
    }
}

