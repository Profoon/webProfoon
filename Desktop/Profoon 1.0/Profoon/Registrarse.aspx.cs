﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Libreria.EN;
using Libreria.CAD;

namespace Profoon
{
    public partial class Registrarse : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                ClientesEN cliente = new ClientesEN(UserName.Text, Password.Text, Email.Text, Name.Text, Apellido.Text,true);
                Response.Write(cliente.Dni + " " + cliente.Password + " " + cliente.Email + " " + cliente.Nombre + " " + cliente.Apellidos + " " + cliente.FechaAlta + " " + cliente.Tipo_cliente);
                cliente.AgregarCliente();

                Response.Redirect("Default.aspx");
            }
            catch (Exception a) { }
        }
    }
}