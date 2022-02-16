using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public InventoryObject inventory;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {

        var item = other.GetComponent<Item>();
        if (item)
        {
            Debug.Log("Item found");
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }

    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            inventory.Load();
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput,  verticalInput,0);
        movement.Normalize();
        transform.Translate(movement * 6.0f * Time.deltaTime);
    }



    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }


}
