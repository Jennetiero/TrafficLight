using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public class ThreePanelTrafficLight : BaseTrafficLight {
    public ThreePanelTrafficLight(string id) : base(id) {
        PanelCount = 3;
    }
    
    protected override void Button_Click(object sender, EventArgs e) {
        if (CurrentColor == "Red") {
            CurrentColor = "Yellow";
            panels[0].BackColor = Color.FromName("Gray");
            panels[1].BackColor = Color.FromName("Yellow");
            panels[2].BackColor = Color.FromName("Gray");
        } else if (CurrentColor == "Yellow") {
            CurrentColor = "Green";
            panels[0].BackColor = Color.FromName("Gray");
            panels[1].BackColor = Color.FromName("Gray");
            panels[2].BackColor = Color.FromName("Green");
        } else if (CurrentColor == "Green") {
            CurrentColor = "Red";
            panels[0].BackColor = Color.FromName("Red");
            panels[1].BackColor = Color.FromName("Gray");
            panels[2].BackColor = Color.FromName("Gray");
        }
    }
}
