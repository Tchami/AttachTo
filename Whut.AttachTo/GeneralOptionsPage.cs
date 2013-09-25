using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace Whut.AttachTo
{
  public class GeneralOptionsPage : DialogPage
  {
    public GeneralOptionsPage()
    {
      this.ShowAttachToForsikringNet = true;
      this.ShowAttachToHost = true;
      this.ShowAttachToServer = true;
      this.ShowAttachToNUnit = true;
    }

    [Category("General")]
    [DisplayName("Show 'Attach to Forsikring.Net' command")]
    [Description("Show 'Attach to Forsikring.Net' command in Tools menu.")]
    [DefaultValue(true)]
    public bool ShowAttachToForsikringNet { get; set; }

    [Category("General")]
    [DisplayName("Show 'Attach to Host' command")]
    [Description("Show 'Attach to Host' command in Tools menu.")]
    [DefaultValue(true)]
    public bool ShowAttachToHost { get; set; }

    [Category("General")]
    [DisplayName("Show 'Attach to Server' command")]
    [Description("Show 'Attach to Server' command in Tools menu.")]
    [DefaultValue(true)]
    public bool ShowAttachToServer { get; set; }

    [Category("General")]
    [DisplayName("Show 'Attach to NUnit' command")]
    [Description("Show 'Attach to NUnit' command in Tools menu.")]
    [DefaultValue(true)]
    public bool ShowAttachToNUnit { get; set; }
  }
}
