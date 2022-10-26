using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI.WebControls;

public class OnePanelTrafficLight : BaseTrafficLight {
    public OnePanelTrafficLight(string id) : base(id) {
        PanelCount = 1;
    }

    protected override void Button_Click(object sender, EventArgs e) {
        if (CurrentColor == "Red") {
            CurrentColor = "Yellow";
            panels[0].BackColor = Color.FromName("Yellow");
        } else if (CurrentColor == "Yellow") {
            CurrentColor = "Green";
            panels[0].BackColor = Color.FromName("Green");
        } else if (CurrentColor == "Green") {
            CurrentColor = "Red";
            panels[0].BackColor = Color.FromName("Red");
        }
    }
}
