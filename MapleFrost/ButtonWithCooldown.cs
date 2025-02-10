using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace WildfrostHopeMod.MapleFrost
{



    public class ButtonCooldown : StatusEffectApplyX
    {
        public int cooldownCount = 12;
        public int maxCooldown = 12;

        public void SetCooldownText()
        {
            if (target.display.FindStatusIcon(type) is not { } icon) return;
            if (cooldownCount <= 0)
            {
                icon.textElement.text = "";
            }
            else
            {
                icon.textElement.text = string.Format(icon.textFormat, cooldownCount);
            }
            icon.StartCoroutine(Pinging());
        }

        public IEnumerator Pinging()
        {
            yield return new WaitForSeconds(0.01f);
            StatusIcon icon = target.display.FindStatusIcon(type);
            icon.Ping();
        }


        public override void Init()
        {
            //OnTurnStart += CooldownCountDown;
        }

        public static void SetUpgradeCooldownText(Entity entity, CardUpgradeData charm)
        {
            if (charm.name != "artemys.wildfrost.frostknights.CardUpgradeAncientGaulishSilverCoin" && charm.name != "artemys.wildfrost.frostknights.CardUpgradeRoyalLiqueur")
            {
                return;
            }
            foreach (CardData.StatusEffectStacks status in entity.data.startWithEffects)
            {
                if (status.data is ButtonCooldown button)
                {
                    if (entity.display.FindStatusIcon(status.data.type) is not { } icon) return;
                    icon.textElement.text = string.Format(icon.textFormat, button.cooldownCount);
                }
            }
        }

        public bool cooldown => this.cooldownCount > 0;

        private IEnumerator CooldownCountDown(Entity entity)
        {
            if (entity != target)
            {
                yield break;
            }
            ButtonCooldown status = this;
            int amount = 1;
            global::Events.InvokeStatusEffectCountDown((StatusEffectData)status, ref amount);
            if (amount != 0 && Battle.IsOnBoard(target))
                cooldownCount -= amount;
            SetCooldownText();
        }
    }
}
