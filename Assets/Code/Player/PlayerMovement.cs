using DSwieringa.Portfolio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DSwieringa.Portfolio {
    public class PlayerMovement : MonoBehaviour {
        private static int animXMoveID = Animator.StringToHash("XMovement");
        private static int animYMoveID = Animator.StringToHash("YMovement");

        //todo move to option later
        [SerializeField]
        private float lookSensitivity = 25;

        float currentXMovement;
        float currentYMovement;

        float cachedDeltaTime;
        Rigidbody rb = null;
        Animator anim = null;

        // Start is called before the first frame update
        void Start() {
            rb = GetComponent<Rigidbody>();
            anim = GetComponent<Animator>();
        }

        private void FixedUpdate() {
            currentXMovement = InputAccessor.DefaultPlayer.GetAxis(InputAccessor.XMovement);
            currentYMovement = InputAccessor.DefaultPlayer.GetAxis(InputAccessor.YMovement);
            cachedDeltaTime = Time.fixedDeltaTime;

            // Move player in all directions
            //rb.AddForce(new Vector3(currentXMovement, 0, currentYMovement) * DefaultPlayerStats.Instance.MovementSpeed * cachedDeltaTime, ForceMode.Acceleration);
            
            anim.SetInteger(animYMoveID, (int)(currentYMovement * 100f));
            anim.SetInteger(animXMoveID, (int)(currentXMovement * 100f));

            // Turn player
            transform.Rotate(Vector3.up * InputAccessor.DefaultPlayer.GetAxis(InputAccessor.XLook) * cachedDeltaTime * lookSensitivity);
        }
    }
}