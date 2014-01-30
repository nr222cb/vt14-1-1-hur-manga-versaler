using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Versaler
{
    public partial class Versaler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            if (VersalerTextBox.Enabled == true)
            {
                int numberOfCapitals = Model.TextAnalyzer.GetNumberOfCapitals(VersalerTextBox.Text);
                VersalerTextBox.Enabled = false;
                ResultLabel.Text = String.Format("Texten innehåller {0} versaler", numberOfCapitals);
                ResultLabel.Visible = true;
                SendButton.Text = "Rensa";
            }
            else
            {
                VersalerTextBox.Text = "";
                VersalerTextBox.Enabled = true;
                ResultLabel.Visible = false;
                SendButton.Text = "Bestäm antalet versaler";
            }
            
        }
    }
}