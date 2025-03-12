namespace WildfrostHopeMod.Leader_Colour_Test
{
    public partial class Leader_Colour_TestMod
    {
        [ConfigItem(6, """
            Number of frames to wait before next colour (6 delay ~ 1s)
            //
            // Smaller delays = More swapping (but might slow down gameplay!)
            """, "Delay")]
        public int delayMax = 10;

        [ConfigItem(100, "Number of total colours to swap between", "Max offset")]
        public int offsetMax = 100;

        [ConfigItem(false, "", "Affect Clothing Colour")]
        public bool affectClothing = false;

        [ConfigItem(true, "", "Affect Hair Colour")]
        public bool affectHair = true;

        [ConfigItem(false, "", "Affect Eye Colour")]
        public bool affectEye = false;

        [ConfigItem(false, "", "Affect Skin Colour")]
        public bool affectSkin = false;

        //[ConfigItem(false, "", "Affect MarkingColour Colour")]
        public bool affectMarking = false;
    }
}