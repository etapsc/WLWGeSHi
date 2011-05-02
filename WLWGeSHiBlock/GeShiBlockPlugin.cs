using System;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using WindowsLive.Writer.Api;

namespace WLWGeSHiBlock
{
    [WriterPluginAttribute ("7F89199E-B857-4DF3-AA30-C7C692A0D57F", "WLW GeSHi Block Plugin",
                            ImagePath="geshi.ico", 
                            PublisherUrl="etapiscium.net",
                            Description="Plugin insert GeShi Code blocks") ]
    [InsertableContentSourceAttribute("Insert GeSHi Code Block", SidebarText="GeSHi Code Block")]
    public class GeShiBlockPlugin : ContentSource
    {
        Configuration.GeSHiConfigSection m_config = null;

        public override void Initialize( IProperties pluginOptions )
        {
            base.Initialize(pluginOptions);

            String path = Assembly.GetExecutingAssembly().Location;
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(path);

            m_config = config.GetSection("GeSHiConfig") as Configuration.GeSHiConfigSection;
        }

        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string newContent)
        {
            InsertTextWindow wnd = new InsertTextWindow(m_config, newContent);
            DialogResult res = wnd.ShowDialog();

            if (res == DialogResult.OK)
            {
                String titleTemplate = wnd.Title.Length > 0 ? " title=\"" + wnd.Title + "\"" : "";

                String numberingTemplate = "";
                if (wnd.Numbering == 1)
                {
                    numberingTemplate = " linenumbers=\"on\" start=\"" + wnd.StartNumber + "\"";
                }
                else if (wnd.Numbering == 2)
                {
                    numberingTemplate = " linenumbers=\"fancy\" start=\"" + wnd.StartNumber + "\"";
                }

                String collapsibleTemplate = wnd.IsCollapsible ? " collapsible=\"true\"" : "";

                newContent = wnd.BlockStyle;
                if (newContent.Length > 0)
                {
                    newContent = newContent.Replace("$title", titleTemplate);
                    newContent = newContent.Replace("$numbering", numberingTemplate);
                    newContent = newContent.Replace("$collapsible", collapsibleTemplate);
                    newContent = newContent.Replace("$language", wnd.Lang);
                    newContent = newContent.Replace("$code", "\n" + wnd.Code + "\n");
                }
            }
            return res;
        }
    }
}
