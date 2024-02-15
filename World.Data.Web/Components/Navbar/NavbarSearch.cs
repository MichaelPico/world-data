namespace World.Data.Web.Components.Navbar
{
    public class NavbarSearch : INavbarInput
    {
        public string Name { get; set; }
        public bool Disable { get; set; }
        /// <summary>
        /// Action that will be triggered when navbar value changes
        /// </summary>
        public Action OnChange { get; set; }
        /// <summary>
        /// Decides if a search button will be added to the navbar
        /// </summary>
        public bool UseSearchButton { get; set; } = false;
        /// <summary>
        /// Search button
        /// </summary>
        public NavbarButton? SearchButton { get; set; }
    }
}
