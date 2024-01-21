using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator_Asp
{
    public partial class Calculator_aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(firstnum.Text) && (!String.IsNullOrEmpty(secondnum.Text)))
            {
                String input1 = firstnum.Text;
                String input2 = secondnum.Text;
                int value1, value2;
                if (int.TryParse(input1 , out value1) && int.TryParse(input2, out value2))
                {
                    int result = value1 + value2;
                    idoutput1.InnerHtml ="addition : " + result.ToString();   
                }
                else
                {
                    idoutput1.InnerHtml = "enter the integer for calculation";
                }
                
            } else{
                idoutput1.InnerHtml = "enter the integer for calculation";

            }
        }
        protected void sub_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(firstnum.Text) && (!String.IsNullOrEmpty(secondnum.Text)))
            {
                String input1 = firstnum.Text;
                String input2 = secondnum.Text;
                int value1, value2;
                if (int.TryParse(input1, out value1) && int.TryParse(input2, out value2))
                {
                    int result = value1 - value2;
                    idoutput1.InnerHtml = "subtraction : " + result.ToString();
                }
                else
                {
                    idoutput1.InnerHtml = "enter the integer for calculation";
                }

            }
            else
            {
                idoutput1.InnerHtml = "enter the integer for calculation";

            }
        }
        protected void div_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(firstnum.Text) && (!String.IsNullOrEmpty(secondnum.Text)))
            {
                String input1 = firstnum.Text;
                String input2 = secondnum.Text;
                int value1, value2;
                if (int.TryParse(input1, out value1) && int.TryParse(input2, out value2))
                {
                    int result = value1 / value2;
                    idoutput1.InnerHtml = "division : " + result.ToString();
                }
                else
                {
                    idoutput1.InnerHtml = "enter the integer for calculation";
                }

            }
            else
            {
                idoutput1.InnerHtml = "enter the integer for calculation";

            }
        }
        protected void mul_click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(firstnum.Text) && (!String.IsNullOrEmpty(secondnum.Text)))
            {
                String input1 = firstnum.Text;
                String input2 = secondnum.Text;
                int value1, value2;
                if (int.TryParse(input1, out value1) && int.TryParse(input2, out value2))
                {
                    int result = value1 * value2;
                    idoutput1.InnerHtml = "multiplication : " + result.ToString();
                }
                else
                {
                    idoutput1.InnerHtml = "enter the integer for calculation";
                }

            }
            else
            {
                idoutput1.InnerHtml = "enter the integer for calculation";

            }
        }
    }
}