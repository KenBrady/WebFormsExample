using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExample.Web
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void submit_Click(object sender, EventArgs e)
		{
			string userName = yourName.Text;
			if (string.IsNullOrEmpty(userName)) return;
			// Make the input panel disappear:
			inputs.Visible = false;
			welcomeMessage.Text = $"Hello, {userName}!";  // string interpolation
			welcomeMessage.ForeColor = System.Drawing.Color.Red;
			
		}
	}
}