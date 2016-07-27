using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
   public class Cliente : ClaseMaestra 
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        
        public Cliente()
        {
            this.ClienteId = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Cedula = "";
            this.Telefono = "";
            this.Email = "";
            this.Direccion = "";
        }
        public Cliente(int id, string nombre, string apellido, string cedula) {
            this.ClienteId = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;

        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("insert into Cliente(Nombre,Apellidos,Cedula,Telefono,Email, Direccion) values('{0}','{1}','{2}','{3}','{4}','{5}')", this.Nombre, this.Apellido, this.Cedula, this.Telefono, this.Email, this.Direccion));

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }
        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Cliente set Nombre= '{0}',Apellidos='{1}',Cedula='{2}',Telefono='{3}',Email='{4}',Direccion='{5}' where ClienteId={6}", this.Nombre, this.Apellido, this.Cedula, this.Telefono, this.Email, this.Direccion, this.ClienteId));
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
                retorno = conexion.Ejecutar(string.Format("delete from Cliente where ClienteId = {0} ", this.ClienteId));
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
            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * From Cliente where ClienteId=" + IdBuscado));
                if (dt.Rows.Count > 0)
                {
                    this.Nombre = dt.Rows[0]["Nombre"].ToString();
                    this.Apellido = dt.Rows[0]["Apellidos"].ToString();
                    this.Cedula = dt.Rows[0]["Cedula"].ToString();
                    this.Telefono = dt.Rows[0]["Telefono"].ToString();
                    this.Email = dt.Rows[0]["Email"].ToString();
                    this.Direccion = dt.Rows[0]["Direccion"].ToString();


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

            return conexion.ObtenerDatos("Select " + Campos + " From Cliente Where " + Condicion + ordenFinal);
        }
    }
}
