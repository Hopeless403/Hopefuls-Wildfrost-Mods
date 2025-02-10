namespace StatusIcons
{
    /// <summary>
    /// Unused code in favour of copying persistent listeners from Snow
    /// </summary>
    public class StatusIconCustom : StatusIcon
    {
        public void Awake()
        {
            var icon = this;
            icon.onCreate = icon.onDestroy = icon.afterUpdate = new();
            icon.onValueUp = icon.onValueDown = new();

            icon.onCreate.AddListener(icon.Ping);
            icon.onValueUp.AddListener((_, _) => icon.Ping());
            icon.onValueDown.AddListener((_, _) => icon.Ping());
            icon.onValueDown.AddListener(icon.CheckDestroy);
            icon.afterUpdate.AddListener(icon.SetText);
        }
    }
}