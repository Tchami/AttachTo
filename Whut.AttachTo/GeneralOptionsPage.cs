using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace Whut.AttachTo
{
    public class GeneralOptionsPage : DialogPage
    {
        public GeneralOptionsPage()
        {
            this.ShowAttachToForsikringNet = true;
            this.ShowAttachToNUnit = true;
        }

        [Category("General")]
        [DisplayName("Show 'Attach to Forsikring.Net' command")]
        [Description("Show 'Attach to Forsikring.Net' command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToForsikringNet { get; set; }

        [Category("General")]
        [DisplayName("Show 'Attach to NUnit' command")]
        [Description("Show 'Attach to NUnit' command in Tools menu.")]
        [DefaultValue(true)]
        public bool ShowAttachToNUnit { get; set; }
    }
}
