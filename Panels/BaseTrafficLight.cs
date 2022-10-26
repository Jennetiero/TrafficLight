using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public abstract class BaseTrafficLight {
    const string defaultColor = "Red";
    protected List<Panel> panels { get; set; } = new List<Panel>();
    protected int PanelCount { get; set; }

    private Panel container;

    public string CurrentColor {
        get {
            if (HttpContext.Current.Session["varColor" + TrafficLightID] != null)
                return HttpContext.Current.Session["varColor" + TrafficLightID].ToString();
            else
                return defaultColor;
        }
        set {
            HttpContext.Current.Session["varColor" + TrafficLightID] = value;
        }
    }

    public BaseTrafficLight(string id) {
        TrafficLightID = id;
    }

    protected void CreatePanel(int currentIndex) {
        Panel tlPanel = new Panel();
        tlPanel.ID = $"{TrafficLightID}_panel_{currentIndex}";
        tlPanel.Height = 100;
        tlPanel.Width = 100;
        tlPanel.BackColor = Color.FromName(CurrentColor);
        container.Controls.Add(tlPanel);
        panels.Add(tlPanel);

        if (panels.Count == 1) {
            tlPanel.BackColor = Color.FromName(CurrentColor);
        } else {
            tlPanel.BackColor = Color.FromName("Gray");
        }
    }

    public void RenderUI(HtmlForm form) {
        CreateContainer(form);
        for (int i = 0; i < PanelCount; i++) {
            CreatePanel(i);
        }
        CreateButton();
    }

    private void CreateContainer(HtmlForm form) {
        container = new Panel();
        container.ID = TrafficLightID;
        form.Controls.Add(container);
    }

    private void CreateButton() {
        Button switchColor = new Button();
        switchColor.ID = $"{TrafficLightID}_button";
        switchColor.Text = "Switch Color";
        switchColor.Click += Button_Click;
        container.Controls.Add(switchColor);
    }

    protected abstract void Button_Click(object sender, EventArgs e);
}
