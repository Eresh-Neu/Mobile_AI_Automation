using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileTest.PageElements
{
    public class Restaurents_Page_Elements
    {
        public string Restaurents = "//android.widget.TextView[@text = 'Restaurants']";
        public string Delivery = "//android.widget.TextView[@text = 'Delivery']";
        public string TheFoxHouse = "//android.widget.TextView[@text = 'The Fox House']";
        public string KFCOldParhamRoad = "//android.widget.TextView[@text = 'KFC Old Parham Road']";
        public string DailySpecial = "//android.widget.RelativeLayout[1]/android.widget.FrameLayout//android.view.View";
        public string TuesdaySpecial = "//android.widget.LinearLayout/android.widget.RelativeLayout//android.view.View";
        public string AddItem = "//android.widget.TextView[@text = 'Add']";
        public string AddCart = "//android.widget.TextView[@text = 'Add to Cart']";
        public string CheckOut = "//android.widget.TextView[@text = 'Checkout (1 item)']";

    }
}
