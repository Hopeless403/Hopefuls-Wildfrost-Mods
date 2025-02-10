// adding storm bells that add a specific node type to each tier (for mod-testing)
// assets is my list of all databuilders

// put this somewhere meaningful like CreateModAssets()
foreach (var node in AddressableLoader.GetGroup<CampaignNodeType>("CampaignNodeType").Where(n => n?.mapNodePrefab?.spriteOptions?.Any() ?? false))
{
    assets.Add(new GameModifierDataBuilder(this)
        .Create(node.name)
        .WithBellSprite("Nothing.png") // change this
        .WithDingerSprite(node.mapNodePrefab.spriteOptions.RandomItem())
        .WithTitle($"<{node.mapNodePrefab.label.textFitter.text}> Bell")
        .WithDescription($"Adds a <{node.mapNodePrefab.label.textFitter.text}> node to each tier")
        .WithVisible()
        .WithValue(+25)
        .WithSetupScripts() // mandatory
        .WithSystemsToAdd() // mandatory
        .WithStartScripts(new Func<Script[]>(() =>
        {
            Script[] scripts = new Script[0];
            for (int i = 0; i < 7; i++)
            {
                var script = ScriptableObject.CreateInstance<ScriptAddCampaignNodes>();
                script.events = new ScriptAddCampaignNodes.Event[]
                {
                new ScriptAddCampaignNodes.Event()
                {
                    tierRange = new Vector2Int(i,i),
                    type = node
                }
                };
                scripts = scripts.With(script);
            }
            return scripts;
        })())
        .WithRingSfxEvent(FMODUnity.RuntimeManager.PathToEventReference("event:/sfx/town/stormbell_activate"))
        .AsHardModeModifier(10)
        );
}

// this can be in your mod class, but I will add it to the ExtendedUI mod
public static GameModifierDataBuilder AsHardModeModifier(
    this GameModifierDataBuilder modifierData,
    int stormPoints)
{
    var hardModeModifier = ScriptableObject.CreateInstance<HardModeModifierData>();
    hardModeModifier.name = modifierData._data.name;
    hardModeModifier.modifierData = modifierData._data;
    hardModeModifier.stormPoints = stormPoints;
    hardModeModifier.unlockedByDefault = true;

    References.instance.hardModeModifiers = References.instance.hardModeModifiers.With(hardModeModifier);
    modifierData = modifierData.WithLinkedStormBell(hardModeModifier);
    return modifierData;
}

public override void Unload()
{
    // you MUST remember to remove your modifiers from the References
	References.instance.hardModeModifiers = References.instance.hardModeModifiers.Where(h => h.modifierData.ModAdded != this).ToArray();
    base.Unload();
    // your other unload code
}