using System;

namespace TrafficLight {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            for (int i = 0; i < 3; i++) {
                var trafficLight = new ThreePanelTrafficLight("ThreePanel " + i);
                trafficLight.RenderUI(form1);
            }
            for (int i = 0; i < 2; i++) {
                var trafficLight = new TwoPanelTrafficLight("TwoPanel " + i);
                trafficLight.RenderUI(form1);
            }
            for (int i = 0; i < 5; i++) {
                var trafficLight = new OnePanelTrafficLight("OnePanel " + i);
                trafficLight.RenderUI(form1);
            }
        }
    }
}
