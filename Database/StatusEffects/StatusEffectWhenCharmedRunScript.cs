using System.Linq;
using UnityEngine;

public class StatusEffectWhenCharmedRunScript : StatusEffectData
{
    const string credit = "Credit to Hopeful";

    public CardScript[] scripts = new CardScript[0]; // scripts to run
    public TargetConstraint[] cardConstraints = new TargetConstraint[0];
    // Example: Use to check if the charmed ally is an item or not, etc

    public bool self = true; // When self is charmed...
    public bool ally = false;// When ally is charmed...
    public bool applyToSelf = true; // Run scripts on self if true, or on the charmed card if false

    public bool whenCharmed = true;
    public bool whenCrowned = false; // Run scripts when a card is crowned?

    public override void Init()
    {
        Events.OnUpgradeAssign += UpgradeAssigned;
    }
    public void OnDestroy()
    {
        Events.OnUpgradeAssign -= UpgradeAssigned;
    }

    public void UpgradeAssigned(Entity entity, CardUpgradeData upgrade)
    {
        if (entity == null || upgrade == null || scripts == null)
        {
            Debug.LogWarning($"StatusEffectWhenCharmedRunScript.UpgradeAssigned: {(entity, upgrade, scripts)} is null");
            return;
        }

        if (!CheckType(upgrade))
            return;

        if (!CheckTarget(entity))
            return;

        foreach (CardScript script in scripts)
            script.Run(applyToSelf ? target.data : entity.data);
    }

    public bool CheckType(CardUpgradeData upgrade)
    {
        return upgrade.type switch
        {
            CardUpgradeData.Type.Crown => whenCrowned,
            _ or CardUpgradeData.Type.Charm => whenCharmed,
        };
    }

    public bool CheckTarget(Entity entity)
    {
        // Check target constraints
        if (cardConstraints != null && cardConstraints.Any(constraint => constraint.Check(entity.data) is false))
            return false;

        // Check if this runs when self is charmed, or ally is charmed
        if (entity == target)
            return self;
        else return ally;
    }
}