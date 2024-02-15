namespace World.Data.Web.Components.Navbar
{
    public class NavbarButton : INavbarInput
    {
        public string Name { get; set; }
        public bool Disable { get; set; } = false;
        /// <summary>
        /// If true activate the button in the navbar
        /// </summary>
        public bool Active { get; set; } = false;
        /// <summary>
        /// Route where the button will redirect
        /// </summary>
        public string Route { get; set; } = "/";
    }
}
