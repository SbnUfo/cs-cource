using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HW30
{
    class Program
    {
        private const string ConnectionString =
            "Server=tcp:DESKTOP-NENSOL7\OLGA,1433;" +
            "Initial Catalog=Reminder; " +
            "Persist Security Info=False;" +
            "User ID=sa;" +
            "Password=123;" +
            "Encrypt=True;";

        public class Order
        {
            public int Id { get; }
            public string Customer { get; }
            public DateTimeOffset OrderDate { get; }
            public double Discount { get; }

            public Order(int id, string customer, DateTimeOffset orderDate, double discount)
            {
                Id = id;
                Customer = customer;
                OrderDate = orderDate;
                Discount = discount;
            }

            public override string ToString()
            {
                return $"Product with id: {Id} {Customer} {OrderDate} {Discount}";
            }
        }
        public interface IOrderRepository
        {
            Task<int> GetCount();
            Task<Order> GetById(int id);
            Task<List<Order>> GetAll();
           
        }
        public class OrderRepository : IOrderRepository
        {
            private readonly string _connection;

            public OrderRepository(string connection)
            {
                _connection = connection;
            }
           

            public async Task<List<Order>> GetAll()
            {
                await using var connection = await GetConnection();

                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT " +
                    "O.Id, " +
                    "C.Name, " +
                    "O.OrderDate, " +
                    "O.Discount " +
                    "FROM [Order] AS O " +
                    "JOIN [Customer] AS C " +
                    "ON O.CustomerId = C.Id ";

                await using var reader = await command.ExecuteReaderAsync();

                var products = new List<Order>();
                var idIndex = reader.GetOrdinal("Id");
                var customerIndex = reader.GetOrdinal("Name");
                var orderDateIndex = reader.GetOrdinal("OrderDate");
                var discountIndex = reader.GetOrdinal("Discount");

                if (!reader.HasRows)
                {
                    return new List<Order>();
                }

                while (await reader.ReadAsync())
                {
                    var product = new Order(
                    reader.GetInt32(idIndex),
                    reader.GetString(customerIndex),
                    reader.GetDateTimeOffset(orderDateIndex),
                    reader.IsDBNull(discountIndex) ? 0 : reader.GetDouble(discountIndex)
                    );
                    products.Add(product);
                }

                return products;
            }

            public async Task<Order> GetById(int id)
            {
                await using var connection = await GetConnection();

                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT " +
                    "O.Id, " +
                    "C.Name, " +
                    "O.OrderDate, " +
                    "O.Discount " +
                    "FROM [Order] AS O " +
                    "JOIN [Customer] AS C " +
                    "ON O.CustomerId = C.Id " +
                    "WHERE O.Id = @id";
                command.Parameters.AddWithValue("id", id);

                await using var reader = await command.ExecuteReaderAsync();

                if (!reader.HasRows)
                {
                    throw new ArgumentException($"Product with id {id} not found");
                }

                var idIndex = reader.GetOrdinal("Id");
                var customerIndex = reader.GetOrdinal("Name");
                var orderDateIndex = reader.GetOrdinal("OrderDate");
                var discountIndex = reader.GetOrdinal("Discount");

                await reader.ReadAsync();

                var product = new Order(
                    reader.GetInt32(idIndex),
                    reader.GetString(customerIndex),
                    reader.GetDateTimeOffset(orderDateIndex),
                    reader.GetDouble(discountIndex)
                );
                return product;
            }

            public async Task<int> GetCount()
            {
                await using var connection = await GetConnection();
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Count(*) FROM [Order] AS O JOIN [Customer] AS C ON O.CustomerId = C.Id";

                return (int)command.ExecuteScalar();
            }
            private async Task<SqlConnection> GetConnection()
            {
                var connection = new SqlConnection(_connection);
                await connection.OpenAsync();
                return connection;
            }

            Task<List<Order>> IOrderRepository.GetAll()
            {
                throw new NotImplementedException();
            }
        }
        private static async Task Main(string[] args)
        {
            var orderRepository = new OrderRepository(ConnectionString);
            Console.WriteLine(await orderRepository.GetCount());
            Console.WriteLine(await orderRepository.GetById(2));
            var test = await orderRepository.GetAll();
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

        }
    }
}

