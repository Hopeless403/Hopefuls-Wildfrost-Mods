using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.KeyboardSupport
{
    public class KeyboardInputSwitcher : BaseInputSwitcher
    {
        public override bool CheckSwitchTo()
        {
            if (!this.canSwitchTo || Console.active)
                return false;
            return (double)Mathf.Abs(InputSystem.GetAxisDelta("Move Vertical")) > 0.0 || (double)Mathf.Abs(InputSystem.GetAxisDelta("Move Horizontal")) > 0.0;
        }

        public override void SwitchTo()
        {
            this.gameObject.SetActive(true);
            MonoBehaviourSingleton<Cursor3d>.instance.usingMouse = false;
            MonoBehaviourSingleton<Cursor3d>.instance.usingTouch = false;
            VirtualPointer.Show();
            CustomCursor.UpdateState();
            UINavigationDefaultSystem.SetStartingItem();
            ControllerButtonSystem.SetControllerStyle();
            InputSystem.mainPlayer.controllers.Mouse.enabled = true;
            RewiredControllerManager.instance.AssignNextPlayer(InputSystem.mainPlayer.id);
            InputSystem.AllowDynamicSelectRelease = true;
        }
    }
}
