using Deadpan.Enums.Engine.Components.Modding;
using WildfrostHopeMod; // ConfigManager

namespace EnumTest;
public class TemplateMod(string modDirectory) : WildfrostMod(modDirectory)
{
    public override string GUID => "hope.wildfrost.test";
    public override string[] Depends => new string[] { };
    public override string Title => "Enum test";
    public override string Description => "";

    /*[ConfigOptions(
        [
            "CardUpgradeNone\nCardUpgradeNone\nCardUpgradeNone\nCardUpgradeNone",
            "CardUpgradeNone\nCardUpgradeNone",
            "CardUpgradeNone\nCardUpgradeNone\nCardUpgradeNone"
        ], new Charms[]
        {
            Charms.None,
            Charms.Fury,
            Charms.Snow_Immune
        })]*/
    [ConfigItem(Charms.None, "Note: configs have to be public non-static", "Enum test")]
    public Charms config;
    public enum Charms
    {
        None = 0,
        Fury = 1 << 0,
        Snow_Immune = 1 << 1,
    }

    [ConfigManagerTitle("Item Offerings")]
    [ConfigManagerDesc("Select...")]
    [ConfigInput]
    [ConfigSlider(0, 256)]
    [ConfigItem(1, null, "Item Choices")]
    public int itemChoices = 3;

    [ConfigItem(0, null, "float test")]
    public float floatConfig;

    [ConfigItem(true, null, "bool test")]
    public bool boolConfig;
}