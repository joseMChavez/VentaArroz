using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
   public class Ventas : ClaseMaestra
    {

        public int VentaId { get; set; }
        public string Cliente { get; set; }
        public string TipoFactura { get; set; }
        public float Total { get; set; }
        public List<Factorizacion> factura { get; set; }

        public Ventas()
        {
            this.VentaId = 0;
            this.Cliente = "";
            this.TipoFactura = "";
            this.Total = 0;
            factura = new List<Factorizacion>();
        }
        public void  AddVenta(int cantidad,string peso, float precio)
        {
            factura.Add(new Factorizacion(cantidad, peso, precio));
        }
        public void Liverar()
        {
            factura.Clear();
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            object identity;
            int retorno = 0;
            try
            {
                identity = conexion.ObtenerValor(string.Format("Insert Into Venta(Cliente,TipoFactura,Total) values('{0}','{1}',{2}) select @@Identity", this.Cliente,TipoFactura,Total));
                retorno = Utility.ConvierteEntero(identity.ToString());
                this.VentaId = retorno;

                foreach (Factorizacion FacturaD in factura)
                {
                    conexion.Ejecutar(string.Format("Insert into Factura(VentaId,Cantidad,Peso,Precio) Values({0},{1},'{2}',{3})" ,retorno,FacturaD.Cantidad, FacturaD.Peso, FacturaD.Precio));
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno > 0;
        }
        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Venta set Cliente='{0}', TipoFactura='{1}',Total= {2} where VentaId={3}", this.Cliente, this.TipoFactura, this.Total , this.VentaId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete  from Factura where VentaId={0}", this.VentaId));
                    foreach (Factorizacion FacturaD in factura)
                    {
                        conexion.Ejecutar(string.Format("Insert into Factura(VentaId,Cantidad,Peso,Precio) Values({0},{1},'{2}',{3})", VentaId, FacturaD.Cantidad, FacturaD.Peso, FacturaD.Precio));
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("Delete  from Factura where VentaId={0};" +
                                                 "Delete  from Venta where VentaId={0}", this.VentaId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            DataTable detalle = new DataTable();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("Select * from Venta where VentaId = {0}", IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.VentaId = (int)dt.Rows[0]["VentaId"];
                    this.Cliente = dt.Rows[0]["Cliente"].ToString();
                    this.TipoFactura = dt.Rows[0]["TipoFactura"].ToString();
                    this.Total = (float)Convert.ToDecimal(dt.Rows[0]["Total"]);

                    detalle = conexion.ObtenerDatos(string.Format("Select * from Factura where VentaId={0}", IdBuscado));

                    detalle.Clear();
                    foreach (DataRow row in detalle.Rows)
                    {
                        AddVenta((int)row["Cantidad"], row["Peso"].ToString(), (float)Convert.ToDecimal(row["Precio"]));
                    }


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt.Rows.Count > 0;
        }
        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Order by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From Venta Where " + Condicion + ordenFinal);
        }
    }
}
