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
}
