
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using Hirabiki.Udon.Works;

namespace Airtime.Player.Movement
{
    [DefaultExecutionOrder(-100)]
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class PlayerControllerSwimSystem : PlayerController
    {
        [Header("Hirabiki SwimSystem")]
        public UdonBehaviour breathSystemEvent;

        public const string STATE_SWIMMING = "Swimming";

        public override void PlayerStateAerialUpdate()
        {
            base.PlayerStateAerialUpdate();
        }

        public virtual void PlayerStateSwimmingStart()
        {
            ApplyPlayerProperties();
            ApplyPlayerGravity();

            // set coyote time
            ledgeJumpTimeRemaining = ledgeJumpTime;

            // set bonus jump time
            bonusJumpTimeRemaining = bonusJumpTime;

            // reset some cooldowns if we touched the ground
            grindingCooldownRemaining = 0.0f;
            wallJumpCooldownRemaining = 0.0f;

            // reset double jump
            inputDoubleJumped = !groundResetsDoubleJump;
        }

        public virtual void PlayerStateSwimmingUpdate()
        {
        }

        public virtual void PlayerStateSwimmingEnd()
        {
        }

        public void OnSwimEnter()
        {
            SetPlayerState(STATE_SWIMMING);

            // passthrough to breath system
            if (Utilities.IsValid(breathSystemEvent))
            {
                breathSystemEvent.SendCustomEvent("OnSwimEnter");
            }
        }

        public void OnSwimExit()
        {
            SetPlayerState(STATE_AERIAL);

            // passthrough to breath system
            if (Utilities.IsValid(breathSystemEvent))
            {
                breathSystemEvent.SendCustomEvent("OnSwimExit");
            }
        }

        public void OnUnderwaterEnter()
        {
            // passthrough to breath system
            if (Utilities.IsValid(breathSystemEvent))
            {
                breathSystemEvent.SendCustomEvent("OnWaterEnter");
            }
        }

        public void OnUnderwaterExit()
        {
            // passthrough to breath system
            if (Utilities.IsValid(breathSystemEvent))
            {
                breathSystemEvent.SendCustomEvent("OnWaterEnter");
            }
        }
    }
}