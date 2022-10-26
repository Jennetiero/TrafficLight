using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace TrafficLight {
    public class TwoPanelTrafficLight : BaseTrafficLight {
        public TwoPanelTrafficLight(string id) : base(id) {
            PanelCount = 2;
        }

        protected override void Button_Click(object sender, EventArgs e) {
            if (CurrentColor == "Red") {
                CurrentColor = "Green";
                panels[0].BackColor = Color.FromName("Gray");
                panels[1].BackColor = Color.FromName("Green");
            } else if (CurrentColor == "Green") {
                CurrentColor = "Red";
                panels[0].BackColor = Color.FromName("Red");
                panels[1].BackColor = Color.FromName("Gray");
            }
        }
    }
}