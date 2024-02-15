namespace World.Data.Web.Components.Navbar
{
    public class NavbarSelect : INavbarInput
    {
        public string Name { get; set; }
        public bool Disable { get; set; }
        /// <summary>
        /// List of buttons in the select
        /// </summary>
        public IEnumerable<NavbarButton>? Buttons {get; set; } 
    }
}
