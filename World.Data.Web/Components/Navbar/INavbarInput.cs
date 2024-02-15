namespace World.Data.Web.Components.Navbar
{
    public interface INavbarInput
    {
        /// <summary>
        /// Name that will be displayed in the input
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// If true input will be disabled
        /// </summary>
        public bool Disable { get; set; }
    }
}
