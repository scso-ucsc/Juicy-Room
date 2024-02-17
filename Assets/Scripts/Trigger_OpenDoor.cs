using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_OpenDoor : MonoBehaviour
{
    //BASED ON "OPENING a DOOR in UNITY on TRIGGER EVENT" - https://www.youtube.com/watch?v=tJiO4cvsHAo
    [SerializeField] private Animator door;
    //[SerializeField] private bool openDoorTrigger = false;
    //[SerializeField] private bool closeDoorTrigger = false;
    private bool doorIsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player") && doorIsOpen == false){
            door.Play("Door_Open", 0, 0f);
            doorIsOpen = true;
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player") && doorIsOpen == true){
            StartCoroutine(closeDoor());
        }
    }

    IEnumerator closeDoor(){
        yield return new WaitForSeconds(2f); //Close door after 2 seconds
        door.Play("Door_Close", 0, 0f);
        doorIsOpen = false;
    }
}
