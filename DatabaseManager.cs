using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class DatabaseManager
{
    private readonly string connectionString;

    public DatabaseManager(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<Producto> GetProductos()
    {
        // Implementar lógica para obtener todos los productos de la base de datos
        // y devolverlos como una lista de objetos Producto.
    }

    public Producto GetProductoById(int id)
    {
        // Implementar lógica para obtener un producto por su ID de la base de datos
        // y devolverlo como un objeto Producto.
    }

    public void CrearProducto(Producto producto)
    {
        // Implementar lógica para crear un nuevo producto en la base de datos.
    }

    public void ActualizarProducto(int id, Producto nuevoProducto)
    {
        // Implementar lógica para actualizar un producto por su ID en la base de datos.
    }

    public void EliminarProducto(int id)
    {
        // Implementar lógica para eliminar un producto por su ID de la base de datos.
    }

    private Producto MapRowToProducto(MySqlDataReader reader)
    {
        // Método auxiliar para mapear un registro de base de datos a un objeto Producto.
    }
}
