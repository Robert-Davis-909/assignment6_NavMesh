using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Camera cam;

    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    public Text ScoreText;
    public Text Safe;
    public Text Captured;
    public int count = 0;
    public int safe = 0;
    public int captured = 0;

    void Start()
    {
        agent.updateRotation = false;    
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            ScoreText.text = "Score: " + count;
        }
        if(other.gameObject.tag == "Enemy")
        {
            captured += 1;
            Captured.text = "Capture: " + captured;
        }
        if (other.gameObject.tag == "Safe")
        {
            safe += 1;
            Safe.text = "Safe: " + safe;
        }
    }
}
