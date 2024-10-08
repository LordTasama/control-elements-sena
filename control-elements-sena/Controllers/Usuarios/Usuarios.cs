﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace control_elements_sena.Controllers.Usuarios
{
    public class Usuarios
    {
        public static string errorMessage = "";
        public static bool CrearUsuario(string nombres, string apellidos, string identificacion, string correo, string password, byte id_rol)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (SqlConnection con = DatabaseConnect.GetConnection())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("CrearUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nom", nombres);
                        cmd.Parameters.AddWithValue("@ape", apellidos);
                        cmd.Parameters.AddWithValue("@ide", identificacion);
                        cmd.Parameters.AddWithValue("@cor", correo);
                        cmd.Parameters.AddWithValue("@pas", hashedPassword);
                        cmd.Parameters.AddWithValue("@idr", id_rol);
                        // Agregar otros parámetros según sea necesario


                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                    if (ex.Number == 2627)
                    {
                        errorMessage = "Identificación o Correo ya existe";
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    errorMessage = "Error al crear usuario. Detalles: " + ex.Message;
                    return false;
                }
            }
        }

        public static bool EditarUsuario(string id, string nombres, string apellidos, string identificacion, string correo, string password, byte id_rol)
        {
            string hashedPassword = "";
            if (password != "")
            {
                hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            }

            if(Session.idUserGlobal.ToString() == id && id_rol != 1)
            {
                errorMessage = "No puedes cambiar tu propio rol de administrador";
                return false;
            }

            using (SqlConnection con = DatabaseConnect.GetConnection())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("EditarUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idu", id);
                        cmd.Parameters.AddWithValue("@nom", nombres);
                        cmd.Parameters.AddWithValue("@ape", apellidos);
                        cmd.Parameters.AddWithValue("@ide", identificacion);
                        cmd.Parameters.AddWithValue("@cor", correo);
                        cmd.Parameters.AddWithValue("@pas", hashedPassword);
                        cmd.Parameters.AddWithValue("@idr", id_rol);
                        // Agregar otros parámetros según sea necesario


                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    errorMessage = "Error al editar usuario. Detalles: " + ex.Message;
                    return false;
                }
            }
        }

        public static bool CambiarEstadoUsuario(long idUsuario, int estado)
        {
            if(ControlPanel.idSessionUser == idUsuario.ToString())
            {
                errorMessage = "No puedes cambiar tu propio estado";
                return false;
            }
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EstadoUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@idu", idUsuario);
                        command.Parameters.AddWithValue("@est", estado);
                        command.Parameters.AddWithValue("@ids", ControlPanel.idSessionUser);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Error al cambiar estado del usuario. Detalles: " + ex.Message;
                return false;
            }
        }

        public static (DataTable, bool) SeleccionarUsuarios()
        {
            DataTable userTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarUsuarios", connection))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(userTable);

                        return (userTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (userTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar usuarios. Detalles: " + ex.Message;
                return (userTable, false);
            }
        }
        public static (DataTable, bool) SeleccionarUsuario(long idUsuario)
        {
            DataTable userTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarUsuario", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@idu", idUsuario);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);


                        connection.Open();
                        adapter.Fill(userTable);

                        return (userTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (userTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar usuario. Detalles: " + ex.Message;
                return (userTable, false);
            }
        }
        public static (DataTable, bool) SeleccionarRoles()
        {
            DataTable userTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarRoles", connection))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(userTable);

                        return (userTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (userTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar roles. Detalles: " + ex.Message;
                return (userTable, false);
            }
        }

    }
}
