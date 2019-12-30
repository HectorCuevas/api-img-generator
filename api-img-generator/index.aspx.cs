using System;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Text;

namespace api_img_generator
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String s = Request.QueryString["ID"].ToString();
                String empresa = Request.QueryString["tp"].ToString();
                fillFormat(s, empresa);
            }
            catch (Exception ex) {
               // lblResponse.Text = "Error en el formato: " + ex;
                //lblResponse.CssClass = "alert alert-danger";
            }
        }

       

        private void fillFormat(String key, string empresa) {
            ServiceReference3.ServicioFormatoSoapClient sv = new ServiceReference3.ServicioFormatoSoapClient("ServicioFormatoSoap");
            DataSet ret = sv.GetDetialByID(key, empresa);
            int counterTables = ret.Tables.Count;
         //   lblResponse.Text = counterTables.ToString();
            if (ret.Tables.Count > 0)
            {
                if (ret.Tables[0].Rows.Count > 0)
                {
                    //Factura electronica
                    lblTipoDocumento.Text = ret.Tables[0].Rows[0]["TipoDocumento"].ToString();
                    lblResolucion.Text = ret.Tables[0].Rows[0]["Resolucion"].ToString();
                    lblSerieDocumento.Text = ret.Tables[0].Rows[0]["SerieDocumento"].ToString();
                    lblNumeroDocumento.Text = ret.Tables[0].Rows[0]["NumeroDocumento"].ToString();
                    lblPagina.Text = ret.Tables[0].Rows[0]["Pagina"].ToString();

                    //Empresa
                    lblNitEmpresa.Text = ret.Tables[0].Rows[0]["NitEmpresa"].ToString();
                    lblSujetoPago.Text = ret.Tables[0].Rows[0]["SujetoPago"].ToString();
                    //lblDireccionEmpresa.Text = ret.Tables[0].Rows[0]["DireccionEmpresa"].ToString();
                    lblDireccionEmpresa.Text = "CALZADA LA PAZ 18-40 ZONA 5 OFIBODEGAS CENTRO CINCO, BODEGA 114";
                    lblDireccionEmpresa.CssClass = "less-font";
                    lblPBX.Text = ret.Tables[0].Rows[0]["PBXEmpresa"].ToString();
                    lblFechaDocumento.Text = ret.Tables[0].Rows[0]["FechaDocumento"].ToString();

                    //Cliente
                    lblNombreCliente.Text = ret.Tables[0].Rows[0]["NombreCliente"].ToString();
                    lblNitCliente.Text = ret.Tables[0].Rows[0]["NitCliente"].ToString();
                    lblDireccionCliente.Text = ret.Tables[0].Rows[0]["DireccionCliente"].ToString();
                    lblDPICliente.Text = ret.Tables[0].Rows[0]["DPICliente"].ToString();
                    lblCreditoCliente.Text = ret.Tables[0].Rows[0]["CreditoCliente"].ToString();
                    lblTelefonoCliente.Text = ret.Tables[0].Rows[0]["TelefonoCliente"].ToString();
                    lblVendedor.Text = ret.Tables[0].Rows[0]["Vendedor"].ToString();

                    //Detalle factura
                    lblTotalLetras.Text = ret.Tables[0].Rows[0]["TotalLetra"].ToString();
                    Decimal granTotalDosCifras = Convert.ToDecimal(ret.Tables[0].Rows[0]["GranTotal"].ToString());
                    lblGranTotal.Text = "Q " + Math.Round(granTotalDosCifras, 2);
                    //GFACE
                    lblTituloGFACE.Text = ret.Tables[0].Rows[0]["TituloGFACE"].ToString();
                    lblTituloFirmaElectronica.Text = ret.Tables[0].Rows[0]["TituloFirmaElectronica"].ToString();


                    lblEmpresaGFACE.Text = ret.Tables[0].Rows[0]["EmpresaGFACE"].ToString();
                    lblNitGFACE.Text = ret.Tables[0].Rows[0]["NitGFACE"].ToString();

                    //Pie
                    lblLeyendaFactura.Text = ret.Tables[0].Rows[0]["LeyendaFactura"].ToString();
                    // lblComentario.Text = ret.Tables[0].Rows[0]["comentario"].ToString()+"\n";
                 
                    for (int i = 0; i <= Convert.ToInt32(ret.Tables[0].Rows[0]["CountTables"].ToString()) ; i++) {

                        HtmlTableCell cantidad = new HtmlTableCell();
                        HtmlTableCell codigo = new HtmlTableCell();
                        HtmlTableCell descripcion = new HtmlTableCell();
                        HtmlTableCell precio = new HtmlTableCell();
                        HtmlTableCell total = new HtmlTableCell();

                        HtmlTableRow fila = new HtmlTableRow();

                        Label lblPrecio = new Label();
                        Label lblCantidad = new Label();
                        Label lblDescripcion = new Label();
                        Label lblCodigo = new Label();
                        Label lblTotal = new Label();
                        

                        //label
                        var desc = new StringBuilder(); 
                        lblCantidad.Text = ret.Tables[0].Rows[i]["CantidadProducto"].ToString();
                        lblCodigo.Text = ret.Tables[0].Rows[i]["CodigoProducto"].ToString();
                        // lblDescripcion.Text = ret.Tables[0].Rows[i]["DescripcionProducto"].ToString()
                        // + Environment.NewLine  + ret.Tables[0].Rows[0]["comentario"].ToString() + "\n";
                        string str = char.ConvertFromUtf32(13);

                        desc.Append(ret.Tables[0].Rows[i]["DescripcionProducto"].ToString());
                        
                        desc.Append(str);

                        desc.Append(ret.Tables[0].Rows[i]["Comentario"].ToString());

                        lblDescripcion.Text= desc.ToString();
                        //lblResponse.Text = desc.ToString();
                        Decimal precioDosCifras = Convert.ToDecimal(ret.Tables[0].Rows[i]["PrecioProducto"].ToString()); 
                        lblPrecio.Text ="Q " + Math.Round(precioDosCifras, 2).ToString();
                        Decimal totalDosCifras = Convert.ToDecimal(ret.Tables[0].Rows[i]["TotalProducto"].ToString());
                        lblTotal.Text ="Q "+ Math.Round(totalDosCifras, 2).ToString();

                        //unir label con celda
                        precio.InnerText = lblPrecio.Text;
                        cantidad.InnerText = lblCantidad.Text;
                        codigo.InnerText = lblCodigo.Text;
                        descripcion.InnerText = lblDescripcion.Text;
                        total.InnerText = lblTotal.Text;
                       
                        fila.Cells.Add(cantidad);
                        fila.Cells.Add(codigo);
                        fila.Cells.Add(descripcion);
                        fila.Cells.Add(precio);
                        fila.Cells.Add(total);
                        secondtables.Rows.Add(fila);

                    }

                }
                else
                {
                    // lblRes3.Text = "Record not found";
                }
            }

        }
    }
}