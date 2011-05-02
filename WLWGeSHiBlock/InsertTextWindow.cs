using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WLWGeSHiBlock
{
    public partial class InsertTextWindow : Form
    {
        private String m_code;

        private String m_lang;
        private String m_title;
        private int m_numbering;
        private String m_start;
        private String m_style;
        private bool m_collapsible;

        public String Code { get { return m_code; } }
        public String Lang { get { return m_lang; } }
        public String Title { get { return m_title; } }
        public int Numbering { get { return m_numbering; } }
        public String StartNumber { get { return m_start; } }
        public String BlockStyle { get { return m_style; } }
        public bool IsCollapsible { get { return m_collapsible; } }

        public class StylePair
        {
            public String StyleName;
            public String StyleTemplate;
            public StylePair( String name, String template )
            {
                StyleName = name;
                StyleTemplate = template; 
            }

            override public String ToString()
            {
                return StyleName;
            }
        };

        public InsertTextWindow(Configuration.GeSHiConfigSection config, String text)
        {
            InitializeComponent();

            if (config != null)
            {
                comboBoxNumbering.Visible = config.showNumbering;
                textBoxStart.Visible = config.showNumbering;
                comboBoxStyle.Visible = config.showNumbering;

                checkBoxCollapsible.Visible = config.showCollapsible;

                comboBoxLang.Items.Clear();
                foreach(Configuration.LanguageElement lang in config.Langauges)
                {
                    comboBoxLang.Items.Add(lang.Value);
                }

                comboBoxStyle.Items.Clear();
                foreach (Configuration.StyleElement style in config.Styles)
                {
                    comboBoxStyle.Items.Add(new StylePair(style.Name, style.Value));
                }
            }

            comboBoxLang.SelectedIndex = 0;
            comboBoxNumbering.SelectedIndex = 0;
            comboBoxStyle.SelectedIndex = 0;
            richTextBox1.Text = text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            m_code = richTextBox1.Text;
            m_lang = (String)comboBoxLang.SelectedItem;
            m_title = textBoxTitle.Text;
            m_numbering = comboBoxNumbering.SelectedIndex;
            m_start = textBoxStart.Text;
            m_style = ((StylePair)comboBoxStyle.SelectedItem).StyleTemplate;
            m_collapsible = checkBoxCollapsible.Checked;
        }
    }
}
