using System.Collections.Generic;
using UnityEngine;

namespace AVR.Exercises
{
    public class VendingManager : MonoBehaviour
    {
        //TODO - What happens if we have multiple vending machines? Central control?
        [SerializeField]
        [Tooltip("Add prefabs of the products the machine will vend")]
        private List<GameObject> products;

        [SerializeField]
        [Tooltip("Point from which cans are produced")]
        private Transform machineExitTransform;

        public void HandleLeftClick()
        {
            VendProduct(); //tell inventory? play sound? reduce/remove object from list?
        }

        private void VendProduct()
        {
            var index = Random.Range(0, products.Count - 1);
            var newProduct = Instantiate(products[index], machineExitTransform.position, Quaternion.identity);

            var rigidBody = newProduct.GetComponent<Rigidbody>();

            if (rigidBody != null)
                rigidBody.AddForce(new Vector3(-0.25f, 0.5f, 0), ForceMode.Impulse);
        }
    }
}