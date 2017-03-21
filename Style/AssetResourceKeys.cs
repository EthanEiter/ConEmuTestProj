using System.Windows;

namespace Esha.Admin.Tools.Style
{
    public static class AssetResourceKeys
    {
        static AssetResourceKeys()
        {
            var type = typeof(AssetResourceKeys);

            FontFamilyLightKey = new ComponentResourceKey(type, "FontFamilyLight");
            FontFamilySemilightKey = new ComponentResourceKey(type, "FontFamilySemilight");
            FontFamilyDefaultKey = new ComponentResourceKey(type, "FontFamilyDefault");
            FontFamilySemiboldKey = new ComponentResourceKey(type, "FontFamilySemibold");
            FontFamilyBoldKey = new ComponentResourceKey(type, "FontFamilyBold");

            FontSizeSmallestKey = new ComponentResourceKey(type, "FontSizeSmallest");
            FontSizeNormalKey = new ComponentResourceKey(type, "FontSizeNormal");
            FontSizeLargeKey = new ComponentResourceKey(type, "FontSizeLarge");
            FontSizeLargerKey = new ComponentResourceKey(type, "FontSizeLarger");
            FontSizeLargestKey = new ComponentResourceKey(type, "FontSizeLargest");

            TextBlockSmallestStyleKey = new ComponentResourceKey(type, "TextBlockSmallestStyle");
            TextBlockNormalStyleKey = new ComponentResourceKey(type, "TextBlockNormalStyle");
            TextBlockLargeStyleKey = new ComponentResourceKey(type, "TextBlockLargeStyle");
            TextBlockLargerStyleKey = new ComponentResourceKey(type, "TextBlockLargerStyle");
            TextBlockLargestStyleKey = new ComponentResourceKey(type, "TextBlockLargestStyle");

            TextBlockSmallHeaderStyleKey = new ComponentResourceKey(type, "TextBlockSmallHeaderStyle");

            TextBoxNormalStyleKey = new ComponentResourceKey(type, "TextBoxNormalStyle");
            TextBoxLargeStyleKey = new ComponentResourceKey(type, "TextBoxLargeStyle");
            TextBoxLargerStyleKey = new ComponentResourceKey(type, "TextBoxLargerStyle");

            LabelNormalStyleKey = new ComponentResourceKey(type, "LabelNormalStyle");
            LabelLargeStyleKey = new ComponentResourceKey(type, "LabelLargeStyle");

            ButtonNormalStyleKey = new ComponentResourceKey(type, "ButtonNormalStyle");
            ButtonLargeStyleKey = new ComponentResourceKey(type, "ButtonLargeStyle");
            WaitingButtonStyle = new ComponentResourceKey(type, "WaitingButtonStyle");

            LicenseGenerationViewStyle = new ComponentResourceKey(type, "LicenseGenerationViewStyle");
        }

        public static ResourceKey FontFamilyLightKey { get; private set; }
        public static ResourceKey FontFamilySemilightKey { get; private set; }
        public static ResourceKey FontFamilyDefaultKey { get; private set; }
        public static ResourceKey FontFamilySemiboldKey { get; private set; }
        public static ResourceKey FontFamilyBoldKey { get; private set; }

        public static ResourceKey FontSizeSmallestKey { get; private set; }
        public static ResourceKey FontSizeNormalKey { get; private set; }
        public static ResourceKey FontSizeLargeKey { get; private set; }
        public static ResourceKey FontSizeLargerKey { get; private set; }
        public static ResourceKey FontSizeLargestKey { get; private set; }

        public static ResourceKey TextBlockSmallestStyleKey { get; private set; }
        public static ResourceKey TextBlockNormalStyleKey { get; private set; }
        public static ResourceKey TextBlockLargeStyleKey { get; private set; }
        public static ResourceKey TextBlockLargerStyleKey { get; private set; }
        public static ResourceKey TextBlockLargestStyleKey { get; private set; }

        public static ResourceKey TextBlockSmallHeaderStyleKey { get; private set; }

        public static ResourceKey TextBoxNormalStyleKey { get; private set; }
        public static ResourceKey TextBoxLargeStyleKey { get; private set; }
        public static ResourceKey TextBoxLargerStyleKey { get; private set; }

        public static ResourceKey LabelNormalStyleKey { get; private set; }
        public static ResourceKey LabelLargeStyleKey { get; private set; }

        public static ResourceKey ButtonNormalStyleKey { get; private set; }
        public static ResourceKey ButtonLargeStyleKey { get; private set; }
        public static ResourceKey WaitingButtonStyle { get; private set; }

        public static ResourceKey LicenseGenerationViewStyle { get; private set; }
    }
}
