using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighwireAPIWrapper
{
    public enum eHttpMethod
    {
        Post,
        Get,
        Delete,
        Put
    }

    public enum eThemeTemplateName
    {
        AboutUs, 
        Cart, 
        ContactUs, 
        CustomPages, 
        Home, 
        ProductDetails, 
        ProductResults, 
        Terms
    }

    public enum eAppendGalleryPreference : byte
    {
        None = 0,
        Wide = 1
    }

    public enum eAmazonProductOptionType : byte
    {
        Key_Product_Features,
        Platinum_Keywords,
        Search_Terms,
        Intended_Use,
        Target_Audience,
        Other_Attributes,
        Subject_Matter,
        CPSIA_Cautionary_Statement,
        Fabric_Type,
        Department,
        Subject_Keywords,
        Contributor,
        Language
    }
}
