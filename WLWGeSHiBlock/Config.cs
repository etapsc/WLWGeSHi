using System;
using System.Configuration;

using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Text;

namespace WLWGeSHiBlock.Configuration
{
    public class GeSHiConfigSection : ConfigurationSection
    {
        private static ConfigurationProperty s_showNumbering;
        private static ConfigurationProperty s_showCollapsible;
        private static ConfigurationProperty s_langElement;
        private static ConfigurationProperty s_styleElement;
        
        private static ConfigurationPropertyCollection s_properties;

        static GeSHiConfigSection()
        {
            s_showNumbering = new ConfigurationProperty(
                "showNumbering",
                typeof(bool),
                false,
                ConfigurationPropertyOptions.None
            );

            s_showCollapsible = new ConfigurationProperty(
                "showCollapsible",
                typeof(bool),
                false,
                ConfigurationPropertyOptions.None
            );

            s_langElement = new ConfigurationProperty(
                "langauges",
                typeof(LanguageElementCollection),
                null,
                ConfigurationPropertyOptions.IsRequired
            );

            s_styleElement = new ConfigurationProperty(
                "styles",
                typeof(StyleElementCollection),
                null,
                ConfigurationPropertyOptions.IsRequired
            );

            s_properties = new ConfigurationPropertyCollection();

            s_properties.Add(s_showNumbering);
            s_properties.Add(s_showCollapsible);
            s_properties.Add(s_langElement);
            s_properties.Add(s_styleElement);
        }

        [ConfigurationProperty("showNumbering")]
        public bool showNumbering
        {
            get { return (bool)base[s_showNumbering]; }
        }

        [ConfigurationProperty("showCollapsible")]
        public bool showCollapsible
        {
            get { return (bool)base[s_showCollapsible]; }
        }

        [ConfigurationProperty("langauges")]
        public LanguageElementCollection Langauges
        {
            get { return (LanguageElementCollection)base[s_langElement]; }
        }

        [ConfigurationProperty("styles")]
        public StyleElementCollection Styles
        {
            get { return (StyleElementCollection)base[s_styleElement]; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return s_properties; }
        }
    }

    #region Language
    public class LanguageElement : ConfigurationElement
    {
        private static ConfigurationProperty s_propName;
        private static ConfigurationProperty s_propValue;

        private static ConfigurationPropertyCollection s_properties;

        static LanguageElement()
        {
            s_propName = new ConfigurationProperty(
                "name",
                typeof(string),
                null,
                ConfigurationPropertyOptions.IsRequired
            );

            s_propValue = new ConfigurationProperty(
                "value",
                typeof(string),
                null,
                ConfigurationPropertyOptions.None
            );

            s_properties = new ConfigurationPropertyCollection();

            s_properties.Add(s_propName);
            s_properties.Add(s_propValue);
        }

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)base[s_propName]; }
        }

        [ConfigurationProperty("value")]
        public string Value
        {
            get { return (string)base[s_propValue]; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return s_properties; }
        }
    }

    [ConfigurationCollection(typeof(LanguageElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class LanguageElementCollection : ConfigurationElementCollection
    {
        static LanguageElementCollection()
        {
            m_properties = new ConfigurationPropertyCollection();
        }

        public LanguageElementCollection()
        {
        }

        private static ConfigurationPropertyCollection m_properties;

        protected override ConfigurationPropertyCollection Properties
        {
            get { return m_properties; }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.AddRemoveClearMap; }
        }

        public LanguageElement this[int index]
        {
            get { return (LanguageElement)base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                base.BaseAdd(index, value);
            }
        }

        public LanguageElement this[string name]
        {
            get { return (LanguageElement)base.BaseGet(name); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new LanguageElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as LanguageElement).Name;
        }
    }
    #endregion

    #region Style
    public class StyleElement : ConfigurationElement
    {
        private static ConfigurationProperty s_propName;
        private static ConfigurationProperty s_propValue;

        private static ConfigurationPropertyCollection s_properties;

        static StyleElement()
        {
            s_propName = new ConfigurationProperty(
                "style",
                typeof(string),
                null,
                ConfigurationPropertyOptions.IsRequired
            );

            s_propValue = new ConfigurationProperty(
                "value",
                typeof(string),
                null,
                ConfigurationPropertyOptions.None
            );

            s_properties = new ConfigurationPropertyCollection();

            s_properties.Add(s_propName);
            s_properties.Add(s_propValue);
        }

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (string)base[s_propName]; }
        }

        [ConfigurationProperty("value")]
        public string Value
        {
            get { return (string)base[s_propValue]; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return s_properties; }
        }
    }

    [ConfigurationCollection(typeof(StyleElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class StyleElementCollection : ConfigurationElementCollection
    {
        static StyleElementCollection()
        {
            m_properties = new ConfigurationPropertyCollection();
        }

        public StyleElementCollection()
        {
        }

        private static ConfigurationPropertyCollection m_properties;

        protected override ConfigurationPropertyCollection Properties
        {
            get { return m_properties; }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.AddRemoveClearMap; }
        }

        public StyleElement this[int index]
        {
            get { return (StyleElement)base.BaseGet(index); }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                base.BaseAdd(index, value);
            }
        }

        public StyleElement this[string name]
        {
            get { return (StyleElement)base.BaseGet(name); }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new StyleElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return (element as StyleElement).Name;
        }
    }
    #endregion
}
