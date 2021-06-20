using System.ComponentModel.DataAnnotations;

namespace ViewModels.Installer
{
    public class InstallerViewModel
    {
        public InstallerViewModel() : base()
        {
        }
        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.FullName))]
        public string FullName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.UserName))]
        public string InstallerUserName { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.UserNumber))]
        public string UserNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.NationalCode))]
        public string NationalCode { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.PhoneNumber))]
        public string PhoneNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.MobileNumber))]
        public string MobileNumber { get; set; }
        // *****

        // *****
        [Display(ResourceType = typeof(Resources.Installer),
           Name = nameof(Resources.Installer.Address))]
        public string Address { get; set; }
        // *****
    }
}