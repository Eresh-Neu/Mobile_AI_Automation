using MobileTest.PageElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileTest.HelperMethods
{
    public class Retaurents_Page : BaseClass
    {
        CommonMethods cm = new CommonMethods();
        Restaurents_Page_Elements rpe = new Restaurents_Page_Elements();
        public void ClickOnRestaurents()
        {
            cm.ClickOnElement(rpe.Restaurents);  
        }
        public void ClickOnRestaurentName()
        {
            cm.ClickOnElement(rpe.KFCOldParhamRoad);
        }
    }
}
